using EcomLogin_API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EcomLogin_API.Logica
{
    public interface ILoginService
    {
        bool Acceder(String email, String clave);
    }


    public class LoginService : ILoginService
    {

        private EcomLoginApiContext _context;

        public LoginService(EcomLoginApiContext context)
        {
            this._context = context;
        }

        public bool Acceder(string email, string clave)
        {
            bool exitoso = false;

            Usuario buscado = _context.Usuarios.Where(u=>u.Email == email).FirstOrDefault();

            if(buscado != null && buscado.Contrasena == clave)
            {
                exitoso = true;
            }
            return exitoso;
        }
    }
}
