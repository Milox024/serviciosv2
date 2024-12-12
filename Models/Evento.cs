using System;
using System.Collections.Generic;

namespace chaknuul_services.Models;

public partial class Evento
{
    public int Id { get; set; }

    public int Tipo { get; set; }

    public string Imagen { get; set; } = null!;

    public string Lugar { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string Subtitulo { get; set; } = null!;

    public string Informacion { get; set; } = null!;

    public string? Objetivo { get; set; }

    public string? Incluye { get; set; }

    public string? Actividades { get; set; }

    public string? Itinerario { get; set; }

    public string? Comentarios { get; set; }

    public string? Llamada { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaEdicion { get; set; }

    public bool? Foco { get; set; }
}
