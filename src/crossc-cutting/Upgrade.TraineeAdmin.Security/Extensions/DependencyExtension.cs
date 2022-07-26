using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Upgrade.TraineeAdmin.Security.Extensions
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddSecurity(this IServiceCollection services, IConfiguration configuration)
        {
            var origins = configuration["CORS"].Split(";");
            services.AddCors(
                options => options.AddPolicy("mypolicy", builder => builder.WithOrigins(origins)));
            
            Console.WriteLine($"Identity Server Address: {configuration["IAM_Address"]}");
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    // base-address of your identity server
                    options.Authority = configuration["IAM_ADDRESS"];
                    options.RequireHttpsMetadata = false;

                    // if you are using API resources, you can specify the name here
                    options.Audience = "trainee-admin-service";
                    // IdentityServer emits a typ header by default, recommended extra check
                    options.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };
                });
            services.AddAuthorization();
            return services;
        }
    }
}