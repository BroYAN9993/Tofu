using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseService.Models
{
    public class CGAlert 
    {
        public int Id { get; set; }
        public string AlertName { get; set; }
        public int RepoId { get; set; }

        public Repo Repo { get; set; }
        public IEnumerable<CGAlertPackage> CGAlertPackages { get; set; }
        public IEnumerable<WorkItem> WorkItems { get; set; }
    }

    public class CGAlertEntityTypeConfiguration : IEntityTypeConfiguration<CGAlert>
    {
        public void Configure(EntityTypeBuilder<CGAlert> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.Property(b => b.AlertName)
                .IsRequired();
            builder.Property(b => b.RepoId)
                .IsRequired();
            builder.HasOne(b => b.Repo)
                .WithMany(r => r.CGAlerts)
                .HasForeignKey(b => b.RepoId);
            builder.HasMany(b => b.CGAlertPackages);
            builder.HasMany(b => b.WorkItems);
        }
    }
}
