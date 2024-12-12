using System;
using System.Collections.Generic;

namespace chaknuul_services.Models;

public partial class EventosV2
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Lugar { get; set; }

    public string? Titulo { get; set; }

    public string? SubTitulo { get; set; }

    public string Contenido { get; set; } = null!;

    public bool Activio { get; set; }
}
