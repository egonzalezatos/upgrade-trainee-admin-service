using Microsoft.EntityFrameworkCore;

namespace Upgrade.TraineeAdmin.Infrastructure.Configurations
{
    public class InMemoryConfiguration
    {
        public static DbContextOptionsBuilder Configure(DbContextOptionsBuilder options, string database)
        {
            options.UseInMemoryDatabase(database);
            return options;
        }
    }
}