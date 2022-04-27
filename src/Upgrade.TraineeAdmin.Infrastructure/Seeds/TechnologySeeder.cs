using System;
using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class TechnologySeeder
    {
        private static object[] data =
        {
            new {Id = 1, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = ".NET"},
            new {Id = 2, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Java"},
            new {Id = 3, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Angular 2"},
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Technology>()
                .HasData(data);
        }
    }
}