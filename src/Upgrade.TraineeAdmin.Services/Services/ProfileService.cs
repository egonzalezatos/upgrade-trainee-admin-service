
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upgrade.TraineeAdmin.Domain.Models;
using Upgrade.TraineeAdmin.Domain.Repositories;
using Upgrade.TraineeAdmin.Exceptions;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;
using Upgrade.TraineeAdmin.Services.Abstractions.Mappers;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Services.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IJobProfileRepository _profileRepository;
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly ITraineeRepository _traineeRepository;
        private readonly IEntityMapper<JobProfile> _profileMapper;
        private readonly IPositionRepository _positionRepository;
        private readonly ILevelRepository _levelRepository;
        private readonly ITechnologyRepository _technologyRepository;

        public ProfileService(
            IJobProfileRepository profileRepository, 
            IUserProfileRepository userProfileRepository, 
            IEntityMapper<JobProfile> profileMapper, 
            IPositionRepository positionRepository, 
            ILevelRepository levelRepository, 
            ITechnologyRepository technologyRepository, ITraineeRepository traineeRepository)
        {
            _profileRepository = profileRepository;
            _userProfileRepository = userProfileRepository;
            _profileMapper = profileMapper;
            _positionRepository = positionRepository;
            _levelRepository = levelRepository;
            _technologyRepository = technologyRepository;
            _traineeRepository = traineeRepository;
        }

        public async Task<List<DTOs.Profile>> GetAll()
        {
            List<JobProfile> profiles = await _profileRepository.FindAll();
            return _profileMapper.ToDto<DTOs.Profile>(profiles);
        }
        
        public async Task<List<DTOs.Profile>> GetByUserId(int userId)
        {
            List<Trainee> trainees = await _traineeRepository.FindByUserIds(userId);
            if (!trainees.Any()) throw new EntityNotFoundException();
            IEnumerable<JobProfile> profiles = trainees.First().JobProfiles;
            return _profileMapper.ToDto<DTOs.Profile>(profiles.ToList());
        }
        
        public async Task<List<DTOs.Profile>> GetByUsersIds(List<int> userIds)
        {
            List<Trainee> trainees = await _traineeRepository.FindByUserIds(userIds.ToArray());
            IEnumerable<JobProfile> jobProfiles = new List<JobProfile>();
            trainees.ForEach(trainee => jobProfiles = jobProfiles.Concat(trainee.JobProfiles));
            return _profileMapper.ToDto<DTOs.Profile>(jobProfiles.ToList());
        }

        public async Task<DTOs.Profile> GetByFlattenPlan(int positionId, int levelId, int technologyId)
        {
            JobProfile profile =
                await _profileRepository.FindByPositionIdAndLevelIdAndTechnologyId(positionId, levelId, technologyId);
            return _profileMapper.ToDto<DTOs.Profile>(profile);
        }

        public virtual async Task<DTOs.Profile> Create(DTOs.CreateProfile createProfile)
        {
            Level level = (await _levelRepository.FindById(createProfile.LevelId))!;
            Position position = (await _positionRepository.FindById(createProfile.PositionId))!;
            Technology technology = (await _technologyRepository.FindById(createProfile.TechnologyId))!;
            JobProfile profile = new JobProfile();
            profile.Level = level;
            profile.Position = position;
            profile.Technology = technology;
            
            _profileRepository.Add(profile);
            await _profileRepository.SaveAsync();
            return _profileMapper.ToDto<DTOs.Profile>(profile);
        }
    }
}