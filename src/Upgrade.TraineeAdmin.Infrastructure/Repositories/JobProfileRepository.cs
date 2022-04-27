using System;
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
    public class JobProfileRepository : Repository<JobProfile, int>, IJobProfileRepository
    {
        public JobProfileRepository(IUnitOfWork context) : base(context)
        {
        }
        public async Task<JobProfile> FindByPositionIdAndLevelIdAndTechnologyId(int positionId, int levelId, int technologyId)
        {
            var query = DbSet.Where(entity => entity.Position.Id == positionId)
                .Where(entity => entity.Level.Id == levelId)
                .Where(entity => entity.Technology.Id == technologyId);
            return await query.FirstAsync();
        }

        public override async Task<List<JobProfile>> FindAll(CancellationToken cancellationToken = default)
        {
            IQueryable<JobProfile> query = 
                DbSet
                    .Include(p => p.Level)
                    .Include(p => p.Technology)
                    .Include(p => p.Position);
            Console.Out.WriteLine(query.ToQueryString());
            return await query.ToListAsync();
        }

        
    }
}