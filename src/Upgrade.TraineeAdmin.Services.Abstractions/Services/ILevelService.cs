using System.Collections.Generic;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.DTO.DTOs;

namespace Upgrade.TraineeAdmin.Services.Abstractions.Services
{
    public interface ILevelService : IService
    {
        public Task<List<Level>> GetAll();
        public Task<List<Level>> GetByUserIdPositionId(int userId, int positionId);
    }
}