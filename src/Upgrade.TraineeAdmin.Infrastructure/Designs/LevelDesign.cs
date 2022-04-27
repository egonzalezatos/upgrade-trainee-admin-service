using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdk.Infrastructure;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Designs
{
    public class LevelDesign : EntityDesign<Level, int, int>
    {
        public override void Design(EntityTypeBuilder<Level> builder)
        {
            builder.HasIndex(entity => entity.Name).IsUnique();
            builder.Property(entity => entity.Name).HasMaxLength(150);

            builder.Property(entity => entity.Description).HasMaxLength(250);
        }
    }
}