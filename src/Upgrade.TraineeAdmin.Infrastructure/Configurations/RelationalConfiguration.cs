using Microsoft.EntityFrameworkCore;

namespace Upgrade.TraineeAdmin.Infrastructure.Configurations
{
    public class RelationalConfiguration
    {
        public static DbContextOptionsBuilder Configure<TContext>(DbContextOptionsBuilder options, string connectionString) where TContext : DbContext
        {
            options.UseSqlServer(connectionString, b =>
            {
                b.MigrationsAssembly(typeof(TContext).Assembly.GetName().Name);
                b.EnableRetryOnFailure();
            });
            return options;
        }
    }
}