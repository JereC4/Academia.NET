using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;

namespace Academia.Domain.Services;

public class MateriaService : IMateriaService
{
    private readonly List<Materia> _materias = new()
    {
        new Materia { Id = 1, Nombre = "Programación I", HorasSemanales = 4, HorasTotales = 64 },
        new Materia { Id = 2, Nombre = "Bases de Datos", HorasSemanales = 3, HorasTotales = 48 }
    };

    public List<Materia> GetAll() => _materias;

    public Materia? GetById(int id) => _materias.FirstOrDefault(m => m.Id == id);

    public void Add(Materia materia)
    {
        materia.Id = _materias.Count == 0 ? 1 : _materias.Max(m => m.Id) + 1;
        _materias.Add(materia);
    }

    public void Update(Materia materia)
    {
        var existing = GetById(materia.Id);
        if (existing == null) return;
        existing.Nombre = materia.Nombre;
        existing.HorasSemanales = materia.HorasSemanales;
        existing.HorasTotales = materia.HorasTotales;
    }

    public void Delete(int id)
    {
        var existing = GetById(id);
        if (existing != null) _materias.Remove(existing);
    }
}

