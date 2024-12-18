using chaknuul_services.Business;
using chaknuul_services.InternalModels;
using chaknuul_services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chaknuul_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CmController : ControllerBase
    {
        [HttpPost("GetEventsAdmin")]
        public IActionResult GetEventsAdmin([FromBody] GenericRequest<int> request)
        {
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(request.Referencia);
                if (validRequest)
                {
                    var eventos = CmBS.InstanceBS.GetEventsAdmin();
                    return Ok(new { ok = true, result = eventos, message = "" });
                }
                else
                {
                    return Ok(new { ok = false, message = "Solicitud Invalida (401)" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpPost("AddOrUpdateEvent")]
        public IActionResult AddOrUpdateEvent([FromBody] GenericRequest<Evento> request)
        {
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(request.Referencia);
                if (validRequest)
                {
                    var eventos = CmBS.InstanceBS.AddOrUpdateEvent(request.Data);
                    return Ok(new { ok = true, result = eventos, message = "" });
                }
                else
                {
                    return Ok(new { ok = false, message = "Solicitud Invalida (401)" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

    }
}
