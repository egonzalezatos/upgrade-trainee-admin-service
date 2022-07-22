using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Seeds
{
    public class TraineeSeeder
    {
        private static object[] data =
        {
            new
            {
                Id = 1, UserProfileId = 1, CurrentCareerId = 1, OnBoardingDate = 
                    BitConverter.GetBytes(DateTimeOffset.Now.ToUnixTimeSeconds()),
                Active = true, CreatedOn = DateTime.Now, CreatedBy = 1, UpdatedOn = DateTime.Now, UpdatedBy = 1,
            },
        };

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Trainee>()
                .HasData(data);
        }
    }
}