using Academia.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Data.EF
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options)
            : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(a => a.IdAlumno);

                entity.Property(a => a.Nombre)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(a => a.Apellido)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(a => a.Dni)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(a => a.FechaNacimiento)
                      .IsRequired();

                entity.Property(a => a.Legajo)
                      .HasMaxLength(20);
            });
        }
    }
}

