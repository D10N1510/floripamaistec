using Bercario.Models;
using Bercario.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Bercario
{
    public class BercarioContexto: DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }


       /* public BercarioContexto(
            DbContextOptions<BercarioContexto> options): base(options)
        {

        }*/

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=DESKTOP-PLEHEET\\SQLEXPRESS;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
        }
    }
}
