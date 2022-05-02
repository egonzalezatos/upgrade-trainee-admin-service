using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Admin - Technology")]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyService _technologyService;

        public TechnologyController(ITechnologyService technologyService)
        {
            _technologyService = technologyService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _technologyService.GetAll());
        }
        
        [HttpGet("user/{userId}/position/{positionId}")]
        public async Task<IActionResult> GetByUserIdPositionId(int userId, int positionId)
        {
            return Ok(await _technologyService.GetByUserIdPositionId(userId, positionId));
        }
    }
}