using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DatabaseService.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }
        public string PackageSource { get; set; }

        public IEnumerable<Location> Locations { get; set; }
        public IEnumerable<CGAlertPackage>CGAlertPackages { get; internal set; }
    }

    public class PackageEntityTypeConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(b => b.Id);
            builder.HasIndex(b => new { b.PackageName, b.Version })
                .IsUnique();
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
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