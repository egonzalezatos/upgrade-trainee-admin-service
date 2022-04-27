using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sdk.Infrastructure.Repositories;
using Upgrade.Sdk.Infrastructure.Abstractions.repositories;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;

namespace Upgrade.TraineeAdmin.Infrastructure.Repositories
{
    public class UserProfileRepository : Repository<UserProfile, int>, IUserProfileRepository
    {
        
        public async Task<List<UserProfile>> FindByUserId(int userId)
        {
            return await DbSet.Where(entity => entity.UserId == userId).ToListAsync();
        }
        
        public async Task<List<UserProfile>> FindByUserIdAndPositionId(int userId, int positionId)
        {
            return await DbSet.Where(entity => entity.UserId == userId && entity.JobProfile.Position.Id == positionId).ToListAsync();
        }
        
        public async Task<List<UserProfile>> FindByUserIds(List<int> userIds)
        {
            var queryable = DbSet.Where(entity => userIds.Contains(entity.UserId))
                .Include(entity => entity.JobProfile)
                .Include(entity => entity.JobProfile.Level)
                .Include(entity => entity.JobProfile.Technology)
                .Include(entity => entity.JobProfile.Position);
                
            Console.Out.WriteLine(queryable.ToQueryString());
            return await queryable.ToListAsync();
        }

        public UserProfileRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}