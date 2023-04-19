using BE_EcomLogin.Controllers;
using EcomLogin_API.Data.Models;
using EcomLogin_API.Logica;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace EcomLogin_API.UnitTest
{
    public class UsuarioControllerTest
    {
        private readonly UsuarioController _usuarioController;
        private readonly IUsuarioServicio _usuarioServicio;
        private readonly EcomLoginApiContext _ecomLoginApiContext;

       
        public UsuarioControllerTest()
        {
            _ecomLoginApiContext = new EcomLoginApiContext();
            _usuarioServicio = new UsuarioServicio(_ecomLoginApiContext);
            _usuarioController = new UsuarioController(_usuarioServicio);
        }

        [Fact]
        public void quePuedaObtenerUn200OkAlBuscarUnUsuarioExistenteTest()
        {
            int id = 1;

            Assert.IsType<OkObjectResult>(_usuarioController.ObtenerUsuario(id).Result);
        }

        [Fact]
        public void quePuedaObtenerNotFoundAlBuscarUsuarioInexistenteTest()
        {
            int id = 15;

            Assert.IsType<NotFoundResult>(_usuarioController.ObtenerUsuario(id).Result);
        }

        [Fact]
        public void queSePuedaObtener200OkAlConsultarListaDeUsuariosTest()
        {
            var result = _usuarioController.ObtenerUsuarios().Result;

            Assert.IsType<OkObjectResult>(result);
        }

    }
}