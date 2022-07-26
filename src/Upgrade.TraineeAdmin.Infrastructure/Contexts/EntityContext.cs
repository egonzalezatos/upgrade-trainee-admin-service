using Microsoft.EntityFrameworkCore;
using Sdk.Infrastructure.Extensions;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Infrastructure.Seeds;

namespace Upgrade.TraineeAdmin.Infrastructure.Contexts
{
    public class EntityContext : DbContext
    {
        private DbSet<Position> Positions { get; set; }
        private DbSet<Level> Levels { get; set; }
        private DbSet<Technology> Technologies { get; set; }
        private DbSet<Trainee> Trainees { get; set; }

        //For User Profiles Management
        private DbSet<UserProfile> UserProfiles { get; set; }

        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyEntityDesigns(typeof(EntityContext));
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            LevelSeeder.Seed(builder);
            PositionSeeder.Seed(builder);
            TechnologySeeder.Seed(builder);
            JobProfileSeeder.Seed(builder);
            UserProfileSeeder.Seed(builder);
            JobProfileTraineeSeed.Seed(builder);
            TraineeSeeder.Seed(builder);
        }
    }
}