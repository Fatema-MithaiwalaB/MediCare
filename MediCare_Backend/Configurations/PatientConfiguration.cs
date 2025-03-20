using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(p => p.PatientId);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.AadharNo).IsRequired().HasMaxLength(12); 
            builder.HasIndex(p => p.AadharNo).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
            builder.HasIndex(p => p.MobileNo).IsUnique();
            builder.Property(p => p.MobileNo).IsRequired().HasMaxLength(15);
            builder.Property(p => p.CreatedBy)
                .IsRequired();  
            builder.Property(p => p.CreatedAt)
                .IsRequired();

            builder.HasMany(p => p.Appointments)
                .WithOne(a => a.Patient)
                .HasForeignKey(p => p.PatientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
