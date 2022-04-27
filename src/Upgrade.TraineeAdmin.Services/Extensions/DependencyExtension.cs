using System;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using Upgrade.TraineeAdmin.Services.Abstractions.Mappers;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;
using Upgrade.TraineeAdmin.Shared.Extensions;

namespace Upgrade.TraineeAdmin.Services.Extensions
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddServices()
                .AddMappers();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.Scan(selector => selector
                .FromAssembliesOf(typeof(IService), typeof(DependencyExtension))
                .AddClasses(classes => classes.Where( type => !type.IsInterface && type.Name.EndsWith("Service")))
                .UsingRegistrationStrategy(RegistrationStrategy.Replace(ReplacementBehavior.ServiceType))
                .AsMatchingInterface()
                .WithScopedLifetime());
            return services;
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(IEntityMapper<>), typeof(DependencyExtension));
            services.Scan(selector => selector
                .FromAssembliesOf(typeof(IEntityMapper<>), typeof(DependencyExtension))
                .AddClasses(classes => classes.Where( type => !type.IsInterface && type.IsAssignableToGenericType(typeof(IEntityMapper<>))))
                .UsingRegistrationStrategy(RegistrationStrategy.Replace(ReplacementBehavior.ServiceType))
                .AsMatchingInterface()
                .WithScopedLifetime());
            
            return services;
        }
    }
}