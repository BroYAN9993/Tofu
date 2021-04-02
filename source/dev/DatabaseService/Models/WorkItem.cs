using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseService.Models
{
    public class WorkItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public int PackageId { get; set; }
        public int LocationId { get; set; }
        public int CGAlertId { get; set; }
        public string Status { get; set; }

        public CGAlertPackage CGAlertPackage { get; set; }
        public Location Location { get; set; } 
    }

    public class WorkItemPackageEntityTypeConfiguration : IEntityTypeConfiguration<WorkItem>
    {
        public void Configure(EntityTypeBuilder<WorkItem> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.CreateTime)
                .IsRequired();
            builder.Property(b => b.Status)
                .IsRequired();
            builder.HasOne(b => b.CGAlertPackage)
                .WithMany(c => c.WorkItems)
                .HasForeignKey(c => new {c.CGAlertId, c.PackageId});
        }
    }
}
