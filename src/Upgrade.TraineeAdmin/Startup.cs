using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Upgrade.TraineeAdmin.Api.Extensions;
using Upgrade.TraineeAdmin.Grpc.Extensions;
using Upgrade.TraineeAdmin.Infrastructure.Extensions;
using Upgrade.TraineeAdmin.IoC.Extensions;

namespace Upgrade.TraineeAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Env { get; }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Replace ConnectionStrings from appsettings using Environment Variables 
            services.ReadConfigurationEnvironments(Configuration);
            
            services
                .AddApi()
                .AddInfrastructure(Configuration)
                .AddDependencies()
                .AddApiSwagger();
            
            
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Seed Data
            app.SeedData();
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();

            app.UseApiSwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseGrpcEndpoints();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
