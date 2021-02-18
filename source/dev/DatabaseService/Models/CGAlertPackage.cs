using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseService.Models
{
    public class CGAlertPackage
    {
        public int CGAlertId { get; set; }
        public int PackageId { get; set; }

        public CGAlert CGAlert { get; set; }
        public Package Package { get; set; }
    }

    public class CGAlertPackageEntityTypeConfiguration : IEntityTypeConfiguration<CGAlertPackage>
    {
        public void Configure(EntityTypeBuilder<CGAlertPackage> builder)
        {
            builder.HasKey(b => new { b.CGAlertId, b.PackageId });
            builder.Property(b => b.CGAlertId)
                .IsRequired();
            builder.Property(b => b.PackageId)
                .IsRequired();
            builder.HasOne(b => b.CGAlert)
                .WithMany(c => c.CGAlertPackages)
                .HasForeignKey(b => b.CGAlertId);
            builder.HasOne(b => b.Package)
                .WithMany(p => p.CGAlertPackages)
                .HasForeignKey(b => b.PackageId);
        }
    }
}