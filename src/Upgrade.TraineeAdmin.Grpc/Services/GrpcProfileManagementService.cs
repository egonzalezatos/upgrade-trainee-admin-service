using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using gRPC;
using Grpc.Core;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;
using Profile = gRPC.Profile;
using DTOs = Upgrade.TraineeAdmin.DTO.DTOs;
namespace Upgrade.TraineeAdmin.Grpc.Services
{
    public class GrpcProfileManagementService : GrpcProfileManagement.GrpcProfileManagementBase
    {
        private readonly IMapper _mapper;
        private readonly IProfileService _profileService;
        public GrpcProfileManagementService(IMapper mapper, IProfileService profileService)
        {
            _mapper = mapper;
            _profileService = profileService;
        }

        public override async Task<ProfilesResponse> GetProfilesByUsersIds(GetProfilesByUsersIdsRequest request, ServerCallContext context)
        {
            ProfilesResponse response = new ProfilesResponse();
            List<DTOs.Profile> profiles = await _profileService.GetByUsersIds(request.UserIds.ToList());
            foreach (DTOs.Profile profileDto in profiles)
            {
                response.Profiles.Add(_mapper.Map<Profile>(profileDto));
            }
            return response;
        }

        public override async Task<GetProfileByFlattenPlanResponse> GetProfileByFlattenPlan(GetProfileByFlattenPlanRequest request, ServerCallContext context)
        {
            GetProfileByFlattenPlanResponse response = new GetProfileByFlattenPlanResponse();
            DTOs.Profile profile = 
                await _profileService.GetByFlattenPlan(request.PositionId, request.LevelId, request.TechnologyId);
            response.Profile = _mapper.Map<Profile>(profile);
            return response;
        }
    }
}