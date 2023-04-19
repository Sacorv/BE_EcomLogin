using EcomLogin_API.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_EcomLogin.Controllers
{
    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        public ILoginService _loginServicio;

        public LoginController(ILoginService loginServicio)
        {
            _loginServicio = loginServicio;
        }

        [HttpGet("iniciarSesion")]
        public async Task<IActionResult> Acceder(String email, String clave)
        {
            try
            {
                var acceso = _loginServicio.Acceder(email, clave);

                if (!acceso)
                {
                    return NotFound();
                }

                return Ok(acceso);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
