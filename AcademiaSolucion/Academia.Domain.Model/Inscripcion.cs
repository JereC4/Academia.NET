using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Model;

public class Inscripcion
{
    public int Id { get; set; }
    public int AlumnoId { get; set; }
    public int CursoId { get; set; }
    public decimal? Nota { get; set; }
}

