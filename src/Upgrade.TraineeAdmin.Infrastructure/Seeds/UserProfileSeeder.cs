using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class UserProfileSeeder
    {
        private static object[] data =
        {
            new {Id = 1, UserId = 1, JobProfileId = 1},
            new {Id = 2, UserId = 1, JobProfileId = 2},
            new {Id = 3, UserId = 1, JobProfileId = 3},
            new {Id = 4, UserId = 1, JobProfileId = 4},
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<UserProfile>()
                .HasData(data);
        }
    }
}