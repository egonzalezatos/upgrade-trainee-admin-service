using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Models.relations;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class JobProfileTraineeSeed
    {
        private static object[] data =
        {
            new {Id = 1, TraineeId = 1, JobProfileId = 1},
            new {Id = 2, TraineeId = 1, JobProfileId = 2},
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<JobProfileTrainee>()
                .HasData(data);
        }
    }
}