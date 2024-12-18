using System;
using System.Collections.Generic;

namespace chaknuul_services.Models;

public partial class PseudoToken
{
    public int Id { get; set; }

    public string Usuario { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public DateTime Creacion { get; set; }

    public DateTime Vigencia { get; set; }
}
