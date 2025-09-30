using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academia.Domain.Model;
using Microsoft.EntityFrameworkCore;


namespace Academia.Data.EF
{
    public class AlumnoRepositoryEF
    {
        private readonly AcademiaContext _context;

        public AlumnoRepositoryEF(AcademiaContext context)
        {
            _context = context;
        }

        public List<Alumno> GetAll()
        {
            return _context.Alumnos.ToList();
        }

        public Alumno GetById(int id)
        {
            return _context.Alumnos.Find(id);
        }

        public void Add(Alumno alumno)
        {
            int totalAlumnos = _context.Alumnos.Count() + 1;
            alumno.Legajo = "A" + totalAlumnos.ToString("D3");

            _context.Alumnos.Add(alumno);
            _context.SaveChanges();
        }

        public void Update(Alumno alumno)
        {
            var existing = _context.Alumnos.Find(alumno.IdAlumno);
            if (existing != null)
            {
                existing.Nombre = alumno.Nombre;
                existing.Apellido = alumno.Apellido;
                existing.Dni = alumno.Dni;
                existing.FechaNacimiento = alumno.FechaNacimiento;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var alumno = _context.Alumnos.Find(id);
            if (alumno != null)
            {
                _context.Alumnos.Remove(alumno);
                _context.SaveChanges();
            }
        }
    }
}

