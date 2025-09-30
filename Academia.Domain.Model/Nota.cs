using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Domain.Model;

public class Nota
{
    public int Id { get; set; }
    public int InscripcionId { get; set; }
    public decimal Valor { get; set; }
}

