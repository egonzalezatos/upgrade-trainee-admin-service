using System.Collections.Generic;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.DTO.DTOs;

namespace Upgrade.TraineeAdmin.Services.Abstractions.Services
{
    public interface ITechnologyService : IService
    {
        public Task<List<Technology>> GetAll();
        public Task<List<Technology>> GetByUserIdPositionId(int userId, int positionId);
    }
}