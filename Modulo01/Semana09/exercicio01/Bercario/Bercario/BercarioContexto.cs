using Bercario.Models;
using Microsoft.EntityFrameworkCore;

namespace Bercario
{
    public class BercarioContexto: DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

    }
}
