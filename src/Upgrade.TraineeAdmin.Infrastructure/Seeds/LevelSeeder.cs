using System;
using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class LevelSeeder
    {
        static object[] data =
        {
            new { Id = 1, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Basic" },
            new { Id = 2, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Intermediate"},
            new { Id = 3, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Advanced" },
            new { Id = 4, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Name = "Super saiyan ultra hyper god green hair " },
        };
        
        public static void Seed(ModelBuilder builder)
        {
            //Arrange
            builder.Entity<Level>()
                .HasData(data);
        }
    }
}