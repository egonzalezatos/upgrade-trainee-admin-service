using Upgrade.TraineeAdmin.Domain.Models;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;
using Profile = AutoMapper.Profile;

namespace Upgrade.TraineeAdmin.Services.MapProfiles
{
    public class TechnologyProfile : Profile
    {
        public TechnologyProfile()
        {
            CreateMap<Technology, DTOs.Technology>();
        }
    }
}