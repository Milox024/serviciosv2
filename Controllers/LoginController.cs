using chaknuul_services.Business;
using chaknuul_services.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace chaknuul_services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioLogin usu)
        {
            try
            {
                UsuariosAdmin ua = SeguridadBS.InstanceBS.GetValidUser(usu);
                if (ua != null)
                {
                    return Ok(new { ok = true, result = ua, message = "" });
                }
                else
                {
                    return Ok(new { ok = false, message = "Usuario y/o Contraseña Invalida" });
                }
            }
            catch (Exception ex) 
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
