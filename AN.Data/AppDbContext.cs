using AN.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AN.Data
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Department>()
                .HasKey(i => i.Id);

            modelBuilder
                .Entity<City>()
                .HasKey(i => i.Id);

            modelBuilder
                .Entity<Position>()
                .HasKey(i => i.Id);
        }
    }
}
