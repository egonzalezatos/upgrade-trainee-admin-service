using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Upgrade.TraineeAdmin.DTO.DTOs;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _profileService.GetAll());
        }
        
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            return Ok(await _profileService.GetByUserId(userId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfile(CreateProfile createProfile)
        {
            return Ok(await _profileService.Create(createProfile));
        }

    }
}