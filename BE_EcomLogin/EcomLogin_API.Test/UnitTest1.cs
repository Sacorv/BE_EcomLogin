using EcomLogin_API.Data.Models;
using EcomLogin_API.Logica;
using System.Net.NetworkInformation;

namespace EcomLogin_API.Test
{
    public class Tests
    {
        private readonly UsuarioServicio _servicio;

        private static Rol rol = new Rol();
        private static EcomLoginApiContext _context = new EcomLoginApiContext();

        public Tests()
        {
            _servicio = new UsuarioServicio(_context);

        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void puedoObtenerLosUsuariosDeUnRolTest()
        {
            List<Usuario> usuarios = new List<Usuario>;
            usuarios.Add(new Usuario());
            usuarios.Add(new Usuario());

            givenUnRolQueTieneUsuarios(rol, usuarios);
            when
            then

            Assert.Pass();
        }

        private void givenUnRolQueTieneUsuarios(Rol rol, List<Usuario> usuarios)
        {
            _servicio.

            throw new NotImplementedException();
        }
    }
}