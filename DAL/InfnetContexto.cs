using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.DAL
{
    public class InfnetContexto : DbContext
    {
        public DbSet<Computadores> Computadores { get; set; }

        public InfnetContexto(DbContextOptions options) : base(options)
        {

        }
    }
}
