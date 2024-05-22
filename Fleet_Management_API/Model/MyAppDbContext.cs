using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Fleet_Management_API.Model
{
    public class MyAppDbContext : DbContext
        
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {
        }
        //permite crear, actualizar, eliminar y leer todas las entidades del modelo
        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Trajectory> Trajectories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trajectory>()
                .HasOne(t => t.Taxi)
                .WithMany()
                .HasForeignKey(t => t.TaxiId);
        }

    
    }
}
