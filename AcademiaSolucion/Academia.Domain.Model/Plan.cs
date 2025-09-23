using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Model;

public class Plan
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public List<Materia> Materias { get; set; } = new();
}

