using System.Collections.Generic;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.DTO.DTOs;

namespace Upgrade.TraineeAdmin.Services.Abstractions.Services
{
    public interface IProfileService : IService
    {
        public Task<List<Profile>> GetAll();
        public Task<List<Profile>> GetByUserId(int userId);
        public Task<List<Profile>> GetByUsersIds(List<int> userIds);
        public Task<Profile> GetByFlattenPlan(int positionId, int levelId, int technologyId);

        public Task<Profile> Create(CreateProfile profile);
    }
}