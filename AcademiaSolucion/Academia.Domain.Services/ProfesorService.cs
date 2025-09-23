using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;

namespace Academia.Domain.Services;

public class ProfesorService : IProfesorService
{
    private readonly List<Profesor> _profesores = new()
    {
        new Profesor { Id = 1, Nombre = "María", Apellido = "Gómez", Especialidad = "Matemática" },
        new Profesor { Id = 2, Nombre = "Luis", Apellido = "Fernández", Especialidad = "Historia" }
    };

    public List<Profesor> GetAll() => _profesores;

    public Profesor? GetById(int id) => _profesores.FirstOrDefault(p => p.Id == id);

    public void Add(Profesor profesor)
    {
        profesor.Id = _profesores.Count == 0 ? 1 : _profesores.Max(p => p.Id) + 1;
        _profesores.Add(profesor);
    }

    public void Update(Profesor profesor)
    {
        var existing = GetById(profesor.Id);
        if (existing == null) return;
        existing.Nombre = profesor.Nombre;
        existing.Apellido = profesor.Apellido;
        existing.Especialidad = profesor.Especialidad;
    }

    public void Delete(int id)
    {
        var existing = GetById(id);
        if (existing != null) _profesores.Remove(existing);
    }
}

