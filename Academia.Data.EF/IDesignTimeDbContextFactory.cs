using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Academia.Data.EF
{
    public class AcademiaContextFactory : IDesignTimeDbContextFactory<AcademiaContext>
    {
        public AcademiaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AcademiaContext>();

            optionsBuilder.UseSqlServer("Server=PC-Jere\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;TrustServerCertificate=True;");

            return new AcademiaContext(optionsBuilder.Options);
        }
    }
}
