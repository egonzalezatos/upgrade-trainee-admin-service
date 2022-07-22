using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Upgrade.TraineeAdmin.Domain.Repositories;
using Upgrade.TraineeAdmin.DTO.DTOs;
using Upgrade.TraineeAdmin.Services.Abstractions.Mappers;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Services.Services
{
    public class TraineeService : ITraineeService
    {
        private readonly ITraineeRepository _traineeRepository;
        private readonly IEntityMapper<Domain.Models.Trainee> _mapper;
        public TraineeService(ITraineeRepository traineeRepository, IEntityMapper<Domain.Models.Trainee> mapper)
        {
            _traineeRepository = traineeRepository;
            _mapper = mapper;
        }

        public async Task<List<Trainee>> GetAll()
        {
            List<Domain.Models.Trainee> trainees = await _traineeRepository.FindAll();
            return _mapper.ToDto<Trainee>(trainees);
        }
    }
}