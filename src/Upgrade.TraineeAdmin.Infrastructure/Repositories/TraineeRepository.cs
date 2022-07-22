using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sdk.Infrastructure.Repositories;
using Upgrade.Sdk.Infrastructure.Abstractions.repositories;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;

namespace Upgrade.TraineeAdmin.Infrastructure.Repositories
{
    public class TraineeRepository : Repository<Trainee, int>, ITraineeRepository
    {
        public TraineeRepository(IUnitOfWork context) : base(context)
        {
        }

        public override Task<List<Trainee>> FindAll(CancellationToken cancellationToken = new())
        {
            return DbSet
                .Include(entity => entity.UserProfile)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<Trainee>> FindByUserIds(params int[] userIds)
        {
            return await DbSet
                .Include(trainee => trainee.JobProfiles)
                .Where(trainee => userIds.Contains(trainee.UserProfile.UserId))
                .ToListAsync();
        }
    }
}