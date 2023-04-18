using EcomLogin_API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomLogin_API.Logica
{

    public interface IUsuarioServicio
    {
        Task<List<Usuario>> Usuarios();
        Task<Usuario> BuscarUsuarioPorId(int id);
    }

    public class UsuarioServicio : IUsuarioServicio
    {
        public EcomLoginApiContext _context;

        public UsuarioServicio(EcomLoginApiContext context)
        {
            _context = context;
        }

        public async Task<Usuario> BuscarUsuarioPorId(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<List<Usuario>> Usuarios()
        {
           return await _context.Usuarios.ToListAsync();
        }
    }
}
