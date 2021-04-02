using DatabaseService.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseService.Contexts
{
    public class SqliteDatabaseContext : DbContext
    {
        public DbSet<CGAlert> CGAlerts { get; set; }
        public DbSet<CGAlertPackage> CGAlertPackages { get; set; }
        public DbSet<Location> Locations { get; set; } 
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<Repo> Repos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=CGAlertDataSource.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CGAlertEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CGAlertPackageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LocationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OwnerEntitiyTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PackageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WorkItemPackageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RepoEntityTypeConfiguration());
        }
    }
}
