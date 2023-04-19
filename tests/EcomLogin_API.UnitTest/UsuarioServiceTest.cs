using BE_EcomLogin.Controllers;
using EcomLogin_API.Data.Models;
using EcomLogin_API.Logica;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomLogin_API.UnitTest
{
    public class UsuarioServiceTest
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly EcomLoginApiContext _ecomLoginApiContext;

        public UsuarioServiceTest()
        {
            _ecomLoginApiContext = new EcomLoginApiContext();
            _usuarioServicio = new UsuarioServicio(_ecomLoginApiContext);
        }

        [Fact]
        public void queNoPuedaBuscarUnUsuarioInexistenteTest()
        {
            int id = 8;

            Assert.Null(_usuarioServicio.BuscarUsuarioPorId(id).Result);
        }

        [Fact]
        public void quePuedaBuscarUnUsuarioExistenteTest()
        {
            int id = 1;

            Assert.NotNull(_usuarioServicio.BuscarUsuarioPorId(id).Result);
        }

    }
}
