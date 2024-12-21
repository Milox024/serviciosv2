using System;
using System.Collections.Generic;

namespace chaknuul_services.Models;

public partial class Partner
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Imagen { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? Whatsapp { get; set; }

    public string? Facebook { get; set; }

    public string? Instagram { get; set; }

    public string? Equis { get; set; }

    public string? Youtube { get; set; }

    public string? Otros { get; set; }

    public string? Otros2 { get; set; }
}
