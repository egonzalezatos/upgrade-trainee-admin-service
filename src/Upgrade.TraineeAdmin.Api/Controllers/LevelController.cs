using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [SwaggerTag("Admin - Level")]
    public class LevelController : ControllerBase
    {
        private readonly ILevelService _levelService;

        public LevelController(ILevelService levelService)
        {
            _levelService = levelService;
        }

        
        /// <summary>
        /// Este endpoint es para obtener todos los seniority levels.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _levelService.GetAll());
        }
        
    }
}