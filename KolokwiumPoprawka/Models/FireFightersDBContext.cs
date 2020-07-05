using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawka.Models
{
    public class FireFightersDBContext : DbContext
    {
        public DbSet<Firefighter> Firefighters { get; set; }
        public DbSet<Action> Actions { get; set; }
        public DbSet<Firefighter_Action> Firefighter_Actions { get; set; }
        public DbSet<FireTruck> FireTrucks { get; set; }
        public DbSet<FireTruck_Action> FireTruck_Actions { get; set; }

        public FireFightersDBContext()
        {

        }
        public FireFightersDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firefighter_Action>().HasKey(fa => new { fa.IdFirefighter, fa.IdAction});
            modelBuilder.Entity<Firefighter_Action>().HasOne(fa => fa.Firefighter).WithMany(f => f.Firefighter_Actions).HasForeignKey(fa => fa.IdFirefighter);
            modelBuilder.Entity<Firefighter_Action>().HasOne(fa => fa.Action).WithMany(a => a.Firefighter_Actions).HasForeignKey(fa => fa.IdAction);
        }
    }
}
