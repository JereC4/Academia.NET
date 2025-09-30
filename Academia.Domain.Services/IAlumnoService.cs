using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;

namespace Academia.Domain.Services;

public interface IAlumnoService
{
    List<Alumno> GetAll();
    Alumno? GetById(int id);
    void Add(Alumno alumno);
    void Update(Alumno alumno);
    void Delete(int id);
}
