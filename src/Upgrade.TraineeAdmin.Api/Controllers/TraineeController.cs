using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Upgrade.TraineeAdmin.Services.Abstractions.Services;

namespace Upgrade.TraineeAdmin.Api.Controllers
{
    [ApiController]
    [Route("api/trainee")]
    [SwaggerTag("Admin")]
    public class TraineeController : ControllerBase
    {
        private readonly ITraineeService _traineeService;

        public TraineeController(ITraineeService traineeService)
        {
            _traineeService = traineeService;
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get() {
            return Ok(await _traineeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTrainee()
        {
            return Ok("null");
        }
    }
}