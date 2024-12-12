using chaknuul_services.Business;
using chaknuul_services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chaknuul_services.Controllers
{
    [Route("api/v1/public/[controller]")]
    [ApiController]
    public class PublicEventsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                List<Evento> events = EventosBS.InstanceBS.GetEventos();
                return Ok(new { ok = true, result = events, message = "" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("proximo")]
        public IActionResult Proximo()
        {
            try
            {
                Evento events = EventosBS.InstanceBS.GetProximo();
                return Ok(new { ok = true, result = events, message = "" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpGet("partners")]
        public IActionResult Partners()
        {
            try
            {
                Evento events = EventosBS.InstanceBS.GetProximo();
                return Ok(new { ok = true, result = events, message = "" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}

