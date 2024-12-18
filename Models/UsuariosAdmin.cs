using System;
using System.Collections.Generic;

namespace chaknuul_services.Models;

public partial class UsuariosAdmin
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool? Activo { get; set; }

    public string? GuidActivo { get; set; }
}
