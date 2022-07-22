using AutoMapper;
using Upgrade.TraineeAdmin.Domain.Models;

namespace Upgrade.TraineeAdmin.Services.MapProfiles
{
    public class TraineeProfile : Profile
    {
        public TraineeProfile()
        {
            CreateMap<Trainee, DTO.DTOs.Trainee>()
                .ForMember(dto => dto.Email, opt => opt.MapFrom(entity => entity.UserProfile.Email))
                .ForMember(dto => dto.DasId, opt => opt.MapFrom(entity => entity.UserProfile.DasId))
                .ReverseMap();
        }
    }
}