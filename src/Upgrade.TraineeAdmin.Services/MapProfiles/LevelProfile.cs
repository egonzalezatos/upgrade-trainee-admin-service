using AutoMapper;
using Upgrade.TraineeAdmin.Domain.Models;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;
namespace Upgrade.TraineeAdmin.Services.MapProfiles
{
    public class LevelProfile : Profile
    {
        public LevelProfile()
        {
            CreateMap<Level, DTOs.Level>();
        }
    }
}