using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
        
        [HttpGet("check-auth")]
        [Log]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> HelloAuth()
        {
            return Ok(await Task.Run(() => "Secret message"));
        } 
    }

    public class LogAttribute : ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            foreach (var keyValuePair in context.HttpContext.Request.Headers)
            {
                Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value}");
            }

            return base.OnActionExecutionAsync(context, next);
        }
    }
}