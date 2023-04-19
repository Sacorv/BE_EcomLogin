using BE_EcomLogin.Controllers;
using EcomLogin_API.Data.Models;
using EcomLogin_API.Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomLogin_API.UnitTest
{
    public class LoginControllerTest
    {
        private readonly EcomLoginApiContext _context;
        private readonly LoginController _loginController;
        private readonly LoginService _loginService;
        

        public LoginControllerTest()
        {
            this._context = new EcomLoginApiContext();
            this._loginService = new LoginService(_context);
            this._loginController = new LoginController(_loginService);
        }

        [Fact]
        public void quePuedaObtener200OkAlIniciarSesionConClaveCorrectaTest()
        {
            String email = "kila@gmail.com";
            String clave = "kila1233";

            Assert.IsType<OkObjectResult>(_loginController.Acceder(email, clave).Result);
        }

        [Fact]
        public void queObtengaNotFoundAlIniciarSesionConClaveErroneaTest()
        {
            String email = "kila@gmail.com";
            String clave = "123";

            Assert.IsType<NotFoundResult>(_loginController.Acceder(email, clave).Result);
        }


    }
}
