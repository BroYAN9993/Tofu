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

        public IEnumerable<CGAlertPackage> CGAlertPackages { get; set; }
    }

    public class CGAlertEntityTypeConfiguration : IEntityTypeConfiguration<CGAlert>
    {
        public void Configure(EntityTypeBuilder<CGAlert> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.HasMany(b => b.CGAlertPackages);
            builder.Property(b => b.AlertName)
                .IsRequired();
        }
    }
}
