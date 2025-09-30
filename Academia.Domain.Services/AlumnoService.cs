using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;

namespace Academia.Domain.Services;

public class AlumnoService : IAlumnoService
{
    private readonly List<Alumno> _alumnos = new()
    {
        new Alumno { IdAlumno = 1, Nombre = "Ana", Apellido = "García", Legajo = "A001" },
        new Alumno { IdAlumno = 2, Nombre = "Juan", Apellido = "Pérez", Legajo = "A002" }
    };

    public List<Alumno> GetAll() => _alumnos;

    public Alumno? GetById(int id) => _alumnos.FirstOrDefault(a => a.IdAlumno == id);

    public void Add(Alumno alumno)
    {
        alumno.IdAlumno = _alumnos.Count == 0 ? 1 : _alumnos.Max(a => a.IdAlumno) + 1;
        _alumnos.Add(alumno);
    }

    public void Update(Alumno alumno)
    {
        var existing = GetById(alumno.IdAlumno);
        if (existing == null) return;
        existing.Nombre = alumno.Nombre;
        existing.Apellido = alumno.Apellido;
        existing.Legajo = alumno.Legajo;
    }

    public void Delete(int id)
    {
        var existing = GetById(id);
        if (existing != null) _alumnos.Remove(existing);
    }
}

