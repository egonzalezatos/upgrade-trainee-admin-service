using System;
using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class UserProfileSeeder
    {
        private static object[] data =
        {
            new {Email = "1@gmail.com", DasId = "1", AddressId = 1, Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1, Id = 1, UserId = 1},
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<UserProfile>()
                .HasData(data);
        }
    }
}