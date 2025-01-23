using chaknuul_services.Business;
using chaknuul_services.InternalModels;
using chaknuul_services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

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
                    Evento evento = request.Data;
                    if (!evento.Imagen.Equals("") && evento.Imagen.Length > 50)
                    {
                        using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(evento.Imagen.Split(',')[1])))
                        {
                            using (Bitmap bm2 = new Bitmap(ms))
                            {
                                string imgUnico = "";
                                imgUnico = Guid.NewGuid().ToString().Substring(0, 10);
                                bm2.Save("../chaknuul/eventimages/" + imgUnico + ".png");
                                evento.Imagen = imgUnico + ".png";
                            }
                        }
                    }
                    var eventoOut = CmBS.InstanceBS.AddOrUpdateEvent(request.Data);
                    return Ok(new { ok = true, result = eventoOut, message = "" });
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
        [HttpGet("UpdateEventStatus")]
        public IActionResult UpdateEventStatus(string referencia, int id)
        {
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(referencia);
                if (validRequest)
                {
                    var evento = CmBS.InstanceBS.UpdateEventStatus(id);
                    return Ok(new { ok = true, result = evento, message = "" });
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
        [HttpPost("DeleteEvent")]
        public IActionResult DeleteEvent([FromBody] GenericRequest<int> request)
        {
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(request.Referencia);
                if (validRequest)
                {
                    var evento = CmBS.InstanceBS.DeleteEvent(request.Data);
                    return Ok(new { ok = true, result = true, message = "" });
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
        [HttpGet("CloneEvent")]
        public IActionResult CloneEvent(string referencia, DateTime fecha, int eid) 
        { 
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(referencia);
                if (validRequest)
                {
                    var evento = CmBS.InstanceBS.CloneEvent(eid, fecha);
                    return Ok(new { ok = true, result = evento, message = "" });
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
        [HttpPost("AddOrUpdateEventV2")]
        public IActionResult AddOrUpdateEvent([FromBody] GenericRequest<EventosV2> request)
        {
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(request.Referencia);
                if (validRequest)
                {
                    var evento = CmBS.InstanceBS.AddOrUpdateEventV2(request.Data);
                    return Ok(new { ok = true, result = evento, message = "" });
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
        [HttpPost("GetTipos")]
        public IActionResult GetTipos([FromBody] GenericRequest<int> request)
        {
            try
            {
                bool validRequest = SeguridadBS.InstanceBS.ValidaReferencia(request.Referencia);
                if (validRequest)
                {
                    var tipos = CmBS.InstanceBS.GetTipos();
                    return Ok(new { ok = true, result = tipos, message = "" });
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
