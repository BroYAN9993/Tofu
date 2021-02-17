using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseService.Models
{
    public class CGAlert 
    {
        public Guid AlertId { get; set; }
        public string AlertName { get; set; }

        public IEnumerable<CGAlertPackage> CGAlertPackages { get; set; }
    }

    public class CGAlertEntityTypeConfiguration : IEntityTypeConfiguration<CGAlert>
    {
        public void Configure(EntityTypeBuilder<CGAlert> builder)
        {
            builder.HasKey(b => b.AlertId);
            builder.Property(b => b.AlertId)
                .IsRequired();
            builder.HasMany(b => b.CGAlertPackages);
            builder.Property(b => b.AlertName)
                .IsRequired();
        }
    }
}
