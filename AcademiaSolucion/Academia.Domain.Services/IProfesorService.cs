using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;

namespace Academia.Domain.Services;

public interface IProfesorService
{
    List<Profesor> GetAll();
    Profesor? GetById(int id);
    void Add(Profesor profesor);
    void Update(Profesor profesor);
    void Delete(int id);
}

