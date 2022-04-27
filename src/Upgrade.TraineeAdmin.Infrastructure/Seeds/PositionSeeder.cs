using System;
using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class PositionSeeder
    {
        private static object[] data =
        {
            new { Id = 1, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Front-end"},
            new { Id = 2, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Back-end"},
            new { Id = 3, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "QA Automation"},
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Position>()
                .HasData(data);
        }
    }
}