using HayEquipo.Models;
using Microsoft.EntityFrameworkCore;

namespace HayEquipo.data
{
    public class HayEquipoContext: DbContext
    {
        public DbSet<Player> Players { get; set; }
        public HayEquipoContext(DbContextOptions<HayEquipoContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Player>().HasData(
                new Player("simon.holmquist@gmail.com", "13579adgjl"),
                new Player("sim.holm@gmail.com", "adgjl13579")
            );
        }
    }
}