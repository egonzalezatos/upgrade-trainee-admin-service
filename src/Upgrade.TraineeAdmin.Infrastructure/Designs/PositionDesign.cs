using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdk.Infrastructure;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Designs
{
    public class PositionDesign : EntityDesign<Position, int, int>
    {
        public override void Design(EntityTypeBuilder<Position> builder)
        {   
            builder.HasIndex(entity => entity.Name).IsUnique();
            builder.Property(entity => entity.Name).HasMaxLength(150);

            builder.Property(entity => entity.Description).HasMaxLength(250);
        }
    }
}