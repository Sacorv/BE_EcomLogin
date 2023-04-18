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
        public void quePuedaObtenerUn200OkAlBuscarUnUsuarioPorIdTest()
        {
            int id = 2;

            Assert.IsType<OkObjectResult>(_usuarioController.ObtenerUsuario(id).Result);
        }

        [Fact]
        public void queSePuedaObtener200OkAlConsultarListaDeUsuariosTest()
        {
            var result = _usuarioController.ObtenerUsuarios().Result;

            Assert.IsType<OkObjectResult>(result);
        }


        //private void thenObtengoElUsarioCorrecto()
        //{
           
        //}

        //private void givenUnaListaDeUsuarios(List<Usuario> usuarios)
        //{
        //    usuarioUno.IdUsuario = 1;
        //    usuarioDos.IdUsuario = 2;
        //    usuarioTres.IdUsuario = 3;

        //    usuarios.Add(usuarioUno);
        //    usuarios.Add(usuarioDos);
        //    usuarios.Add(usuarioTres);
        //}

        //private Usuario whenBuscoUnUsuarioPorId(int id, List<Usuario> usuarios)
        //{
        //    Usuario usuarioBuscado = null;

        //    foreach(Usuario usuario in usuarios)
        //    {
        //        if(usuario.IdUsuario == id)
        //        {
        //            usuarioBuscado = usuario;
        //        }
        //    }
        //    return usuarioBuscado;
        //}
    }
}