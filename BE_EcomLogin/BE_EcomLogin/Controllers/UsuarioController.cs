using EcomLogin_API.Data.Models;
using EcomLogin_API.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_EcomLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        public IUsuarioServicio _servicio;
        public UsuarioController(IUsuarioServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerUsuarios()
        {
            try
            {
                List<Usuario> usuarios = await _servicio.Usuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> ObtenerUsuario(int id)
        {
            try
            {
                Usuario buscado = await _servicio.BuscarUsuarioPorId(id);
                return Ok(buscado);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
