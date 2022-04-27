using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sdk.Infrastructure;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Infrastructure.Designs
{
    public class TechnologyDesign : EntityDesign<Technology, int, int>
    {
    public override void Design(EntityTypeBuilder<Technology> builder)
    {   
        builder.HasIndex(entity => entity.Name).IsUnique();
        builder.Property(entity => entity.Name).HasMaxLength(150);

        builder.Property(entity => entity.Description).HasMaxLength(250);
    }
    }
}