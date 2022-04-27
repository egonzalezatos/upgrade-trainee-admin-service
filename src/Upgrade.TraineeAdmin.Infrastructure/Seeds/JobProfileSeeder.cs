using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class JobProfileSeeder
    {
        private static object[] data =
        {
            new {Id = 1, PositionId = 1, LevelId = 1, TechnologyId = 1},
            new {Id = 2, PositionId = 1, LevelId = 2, TechnologyId = 1},
            new {Id = 3, PositionId = 1, LevelId = 2, TechnologyId = 2},
            new {Id = 4, PositionId = 1, LevelId = 3, TechnologyId = 2},
            new {Id = 5, PositionId = 2, LevelId = 1, TechnologyId = 3},
            new {Id = 6, PositionId = 2, LevelId = 3, TechnologyId = 3},
            new {Id = 7, PositionId = 3, LevelId = 3, TechnologyId = 2},
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<JobProfile>()
                .HasData(data);
        }
    }
}