using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseService.Models
{
    public class Location
    {
        public Guid LocationId { get; set; }
        public Guid PackageId { get; set; }
        public Guid OwnerId { get; set; }
        public string Path { get; set; }

        public Package Package { get; set; }
        public Owner Owner { get; set; }
    }

    public class LocationEntityTypeConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(b => b.LocationId);
            builder.Property(b => b.PackageId)
                .IsRequired();
            builder.Property(b => b.Path)
                .IsRequired();
            builder.HasOne(b => b.Package)
                .WithMany(p => p.Locations);
            builder.HasOne(b => b.Owner)
                .WithMany(o => o.Locations);
        }
    }
}