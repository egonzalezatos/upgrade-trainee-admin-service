using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdk.Infrastructure;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Designs
{
    public class JobProfileDesign : EntityDesign<JobProfile, int>
    {
        public override void Design(EntityTypeBuilder<JobProfile> builder)
        {
            builder.HasOne(p => p.Position).WithMany()
                .IsRequired();
            builder.HasIndex("PositionId").IsUnique(false);
            
            builder.HasOne(p => p.Level).WithMany()
                .IsRequired();
            builder.HasIndex("LevelId").IsUnique(false);

            builder.HasOne(p => p.Technology).WithMany();
        }
    }
}