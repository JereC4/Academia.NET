using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Model;

public class Materia
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public int HorasSemanales { get; set; }
    public int HorasTotales { get; set; }
}

