using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseService.Models
{
    public class Repo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<CGAlert> CGAlerts { get; set; }
    }

    public class RepoEntityTypeConfiguration : IEntityTypeConfiguration<Repo>
    {
        public void Configure(EntityTypeBuilder<Repo> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.Property(b => b.Name)
                .IsRequired();
            builder.HasMany(b => b.CGAlerts);
        }
    }
}
