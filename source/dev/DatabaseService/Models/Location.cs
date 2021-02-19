using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DatabaseService.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public int OwnerId { get; set; }
        public string Path { get; set; }
        public int RowNumber { get; set; }

        public Package Package { get; set; }
        public Owner Owner { get; set; }
    }

    public class LocationEntityTypeConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(b => b.Id);            
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd(); 
            builder.Property(b => b.PackageId)
                .IsRequired();
            builder.Property(b => b.Path)
                .IsRequired();
            builder.HasOne(b => b.Package)
                .WithMany(p => p.Locations)
                .HasForeignKey(b => b.PackageId);
            builder.HasOne(b => b.Owner)
                .WithMany(o => o.Locations)
                .HasForeignKey(b => b.OwnerId);
        }
    }
}