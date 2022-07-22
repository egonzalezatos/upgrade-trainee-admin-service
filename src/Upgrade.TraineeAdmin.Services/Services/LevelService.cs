using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;
using Upgrade.TraineeAdmin.Services.Abstractions.Mappers;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;
namespace Upgrade.TraineeAdmin.Services.Services
{
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository _levelRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IEntityMapper<Level> _levelMapper;
        public LevelService(ILevelRepository levelRepository, IEntityMapper<Level> levelMapper, IUserProfileRepository userProfileRepository)
        {
            _levelRepository = levelRepository;
            _levelMapper = levelMapper;
            _userProfileRepository = userProfileRepository;
        }

        public async Task<List<DTOs.Level>> GetAll()
        {
            List<Level> levels = await _levelRepository.FindAll();
            return _levelMapper.ToDto<DTOs.Level>(levels);
        }
        
    }
}