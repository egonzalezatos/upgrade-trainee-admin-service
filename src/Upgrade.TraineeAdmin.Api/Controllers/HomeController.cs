using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Upgrade.TraineeAdmin.Api.Controllers
{
    [ApiController]
    [Route("/")]
    [SwaggerTag("Admin")]
    public class HomeController : ControllerBase
    {
        
        /// <summary>
        /// Hello mister!!
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Hello()
        {
            return Ok(await Task.Run(() => "Hello mister"));
        } 
    }
}