using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DatabaseService.Models
{
    public class Package
    {
        public Guid PackageId { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }
        public string PackageSource { get; set; }

        public IEnumerable<Location> Locations { get; set; }
        public IEnumerable<CGAlertPackage> CGAlertPackages { get; set; }
    }

    public class PackageEntityTypeConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(b => b.PackageId);
            builder.HasKey(b => new { b.PackageName, b.Version });
            builder.Property(b => b.PackageName)
                .IsRequired();
            builder.Property(b => b.Version)
                .IsRequired();
            builder.Property(b => b.PackageSource)
                .IsRequired();
            builder.HasMany(b => b.Locations);
            builder.HasMany(b => b.CGAlertPackages);
        }
    }
}