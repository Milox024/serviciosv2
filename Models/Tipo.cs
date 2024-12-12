using System;
using System.Collections.Generic;

namespace chaknuul_services.Models;

public partial class Tipo
{
    public int Id { get; set; }

    public string Tipo1 { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Imagen { get; set; }
}
