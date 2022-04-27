using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Upgrade.TraineeAdmin.Grpc.Extensions;
using Upgrade.TraineeAdmin.Infrastructure.Extensions;

namespace Upgrade.TraineeAdmin.IoC.Extensions
{
    public static class EnvironmentsExtension
    {
        public static IServiceCollection ReadConfigurationEnvironments(this IServiceCollection services, IConfiguration configuration)
        {
            configuration["ConnectionStrings:DbConnect"] = configuration.ReadDbConnectionEnvironments();
            configuration["Kestrel:Endpoints:Grpc:Url"] = configuration.ReadGrpcServerEnvironments();
            return services;
        }
    }
}