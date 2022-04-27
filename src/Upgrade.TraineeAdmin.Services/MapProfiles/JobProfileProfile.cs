using AutoMapper;
using Upgrade.TraineeAdmin.Domain.Models;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;

namespace Upgrade.TraineeAdmin.Services.MapProfiles
{
    public class JobProfileProfile : Profile
    {
        public JobProfileProfile()
        {
            CreateMap<JobProfile, DTOs.Profile>()
                .ForMember(p=>p.Position, opt => opt.MapFrom(p=>p.Position));
            CreateMap<DTOs.CreateProfile, JobProfile>();
        }
    }
}