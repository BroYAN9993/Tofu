using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DatabaseService.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }

        public IEnumerable<Location> Locations { get; set; }
    }

    public class OwnerEntitiyTypeConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder.Property(b => b.Name)
                .IsRequired();
            builder.Property(b => b.Alias)
                .IsRequired();
            builder.Property(b => b.Email)
                .IsRequired();

            builder.HasMany(b => b.Locations);
        }
    }
}