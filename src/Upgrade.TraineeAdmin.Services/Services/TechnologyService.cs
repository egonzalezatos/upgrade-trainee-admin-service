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
    public class TechnologyService : ITechnologyService
    {
        private readonly ITechnologyRepository _technologyRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly IEntityMapper<Technology> _technologyMapper;

        public TechnologyService(ITechnologyRepository technologyRepository, IEntityMapper<Technology> technologyMapper, IUserProfileRepository userProfileRepository)
        {
            _technologyRepository = technologyRepository;
            _technologyMapper = technologyMapper;
            _userProfileRepository = userProfileRepository;
        }
        
        public async Task<List<DTOs.Technology>> GetAll()
        {
            List<Technology> levels = await _technologyRepository.FindAll();
            return _technologyMapper.ToDto<DTOs.Technology>(levels);
        }

    }
}