using GestionTorneoFutbol.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GestionTorneoFutbol.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>().HasIndex(o => o.Name).IsUnique();
            modelBuilder.Entity<Team>().HasIndex(o => o.Technical).IsUnique();

            modelBuilder.Entity<Player>().HasIndex(o => o.Document).IsUnique();
            //modelBuilder.Entity<FairPlay>().HasIndex(f => f.Date).IsUnique();
            modelBuilder.Entity<FairPlay>().HasIndex("Date", "TeamId").IsUnique();
            
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<FairPlay> FairPlays { get; set; }
    }
}
