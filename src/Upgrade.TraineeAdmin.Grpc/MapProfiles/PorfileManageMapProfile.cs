using AutoMapper;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;

namespace Upgrade.TraineeAdmin.Grpc.MapProfiles
{
    public class ProfileManageMapProfile : AutoMapper.Profile
    {
        public ProfileManageMapProfile()
        {
            //null string --> ""
            CreateMap<string?, string>().ConvertUsing<NullStringConverter>();

            //DTOs -> gRPC
            CreateMap<DTOs.Profile, gRPC.Profile>()
                .ForMember(source => source.JobPosition, cfg => cfg.MapFrom(dest => dest.Position))
                .ReverseMap();
            CreateMap<DTOs.Technology, gRPC.Technology>().ReverseMap();
            CreateMap<DTOs.Position, gRPC.JobPosition>().ReverseMap();
            CreateMap<DTOs.Level, gRPC.Level>().ReverseMap();
        }
    }

    public class NullStringConverter : ITypeConverter<string?, string>
    {
        public string Convert(string? source, string destination, ResolutionContext context)
        {
            return source ?? string.Empty;
        }
    }
}