using Microsoft.Extensions.DependencyInjection;
using Upgrade.TraineeAdmin.Grpc.Extensions;
using Upgrade.TraineeAdmin.Services.Extensions;

namespace Upgrade.TraineeAdmin.IoC.Extensions
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddApplication();
            services.AddGrpcServices();
            return services;
        }
    }
}