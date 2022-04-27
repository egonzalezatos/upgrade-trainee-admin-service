using Microsoft.EntityFrameworkCore;

namespace Upgrade.TraineeAdmin.Infrastructure.Extensions
{
    public static class MigrateExtension
    {
        public static void MigrateDb(this DbContext context)
        {
            if (context.Database.IsRelational())
                context.Database.Migrate();
            else 
                context.Database.EnsureCreated();
        }
    }
}