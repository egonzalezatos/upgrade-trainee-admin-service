using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sdk.Infrastructure.Extensions;
using Upgrade.TraineeAdmin.Infrastructure.Configurations;
using Upgrade.TraineeAdmin.Infrastructure.Contexts;

namespace Upgrade.TraineeAdmin.Infrastructure.Extensions
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEFCore<EntityContext>(options =>
            {
                if (configuration.IsInMemory())
                    InMemoryConfiguration.Configure(options, database: "test");
                else if (configuration.IsRelational())
                    RelationalConfiguration.Configure<EntityContext>(options,
                        configuration.GetConnectionString("DbConnect"));
            });
            return services;
        }
        
        public static IApplicationBuilder SeedData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                scope.ServiceProvider.GetService<DbContext>().MigrateDb();
            }
            return app;
        }
    }
    
}