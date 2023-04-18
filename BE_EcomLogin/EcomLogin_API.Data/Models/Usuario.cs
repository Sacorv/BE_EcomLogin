using System;
using System.Collections.Generic;

namespace EcomLogin_API.Data.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string? Telefono { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdRol { get; set; }

    public string Contrasena { get; set; } = null!;

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
