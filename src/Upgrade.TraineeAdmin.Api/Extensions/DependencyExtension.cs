using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Upgrade.TraineeAdmin.Security.Extensions;

namespace Upgrade.TraineeAdmin.Api.Extensions
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddApiSwagger();
            return services;
        }

        public static IApplicationBuilder UseApi(this IApplicationBuilder app)
        {
            app.UseApiSwagger();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            return app;
        }        

        public static IServiceCollection AddApiSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                // using System.Reflection;
                var xmlFilename = $"{typeof(DependencyExtension).Assembly.GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TraineeAdmin", Version = "v1" });
            });
            return services;
        }

        public static IApplicationBuilder UseApiSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "CleanArchProject v1"));
            return app;
        }
    }
}
