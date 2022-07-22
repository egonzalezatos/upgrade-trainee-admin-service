using System.Collections.Generic;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.DTO.DTOs;

namespace Upgrade.TraineeAdmin.Services.Abstractions.Services
{
    public interface IPositionService : IService
    {
        public Task<List<Position>> GetAll();
    }
    
}