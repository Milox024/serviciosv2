using chaknuul_services.Business;
using chaknuul_services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chaknuul_services.Controllers
{
    [Route("api/v2/public/[controller]")]
    [ApiController]
    public class PublicEventsV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                List<EventosV2> events = EventosBS.InstanceBS.GetEventosV2();
                return Ok(new { ok = true, result = events, message = "" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
