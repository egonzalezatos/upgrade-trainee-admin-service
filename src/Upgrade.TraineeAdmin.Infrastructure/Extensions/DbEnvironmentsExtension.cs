using System;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Upgrade.TraineeAdmin.Infrastructure.Extensions
{
    public static class DbEnvironmentsExtension
    {
        public static string ReadDbConnectionEnvironments(this IConfiguration configuration)
        {
            var @string = new StringBuilder()
                .Append($"Server={configuration["DB_SERVER"]},{configuration["DB_PORT"]};")
                .Append($"User Id={configuration["DB_USERNAME"]};")
                .Append($"Password={configuration["DB_PASSWORD"]};")
                .Append($"Database={configuration["DB_DATABASE"]};")
                .ToString();
            Console.Out.WriteLine(@string);
            return @string;
        }
    }
}