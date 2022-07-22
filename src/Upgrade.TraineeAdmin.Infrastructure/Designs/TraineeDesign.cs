using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdk.Infrastructure;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Models.relations;

namespace Upgrade.TraineeAdmin.Infrastructure.Designs
{
    public class TraineeDesign : EntityDesign<Trainee, int>
    {
        public override void Design(EntityTypeBuilder<Trainee> builder)
        {
            builder.HasOne(p => p.UserProfile).WithMany()
                .IsRequired();
            
            builder.HasIndex("UserProfileId").IsUnique();

            // builder
            //     .HasMany(p => p.JobProfiles)
            //     .WithMany(p => p.Trainees)
            //     .UsingEntity<JobProfileTrainee>(
            //         right => right.HasOne<JobProfile>().WithMany().HasForeignKey("JobProfileId"),
            //         pivot =>  pivot.HasOne<Trainee>().WithMany().HasForeignKey("TraineeId"));

            builder.Property(trainee => trainee.OnBoardingDate)
                .IsRowVersion();

        }
    }
}