using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdk.Infrastructure;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Models.relations;

namespace Upgrade.TraineeAdmin.Infrastructure.Designs.Relations
{
    public class JobProfileTraineeDesign 
    {
        public void Design(EntityTypeBuilder<JobProfileTrainee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Trainee)
                .WithMany()
                .HasForeignKey("TraineeId");
            builder.HasOne(e => e.JobProfile)
                .WithMany()
                .HasForeignKey("JobProfileId");
        }
    }
}