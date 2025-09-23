using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Model;

public class Curso
{
    public int Id { get; set; }
    public int MateriaId { get; set; }
    public int ComisionId { get; set; }
    public int Anio { get; set; }
    public int Cupo { get; set; }
}

