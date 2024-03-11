using GestaoDeLaboratorios.Controllers;
using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.DAL
{
    public class LabContexto : DbContext
    {
        // public DbSet<ComputadoresController> Computadores { get; set; }

        public LabContexto(DbContextOptions options) : base(options)
        {

        }
        public DbSet<GestaoDeLaboratorios.Models.Computadores> Computadores { get; set; } = default!;

    }
}
