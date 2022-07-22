using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;
using Upgrade.TraineeAdmin.Services.Abstractions.Mappers;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;
namespace Upgrade.TraineeAdmin.Services.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IEntityMapper<Position> _positionMapper;

        public PositionService(IPositionRepository positionRepository, IUserProfileRepository userProfileRepository, IEntityMapper<Position> positionMapper)
        {
            _positionRepository = positionRepository;
            _userProfileRepository = userProfileRepository;
            _positionMapper = positionMapper;
        }

        public async Task<List<DTOs.Position>> GetAll()
        {
            List<Position> positions = await _positionRepository.FindAll();
            return _positionMapper.ToDto<DTOs.Position>(positions);
        }
        
        
    }
}