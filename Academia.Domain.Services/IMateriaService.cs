using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;

namespace Academia.Domain.Services;

public interface IMateriaService
{
    List<Materia> GetAll();
    Materia? GetById(int id);
    void Add(Materia materia);
    void Update(Materia materia);
    void Delete(int id);
}

