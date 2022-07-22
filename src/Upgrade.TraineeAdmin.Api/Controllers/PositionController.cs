using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Admin - Position")]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _positionService.GetAll());
        }
    }
}