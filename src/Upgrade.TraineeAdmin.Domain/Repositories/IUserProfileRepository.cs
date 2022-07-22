using System.Collections.Generic;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Domain.Repositories
{
    public interface IUserProfileRepository
    {
        public Task<List<UserProfile>> FindByUserId(int userId);
        
        public Task<List<UserProfile>> FindByUserIds(List<int> userIds);
    }
}