using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.DoctorId);
            builder.Property(d => d.Qualification).IsRequired().HasMaxLength(100);
            builder.Property(d => d.LicenseNumber).IsRequired().HasMaxLength(50);
            builder.Property(d => d.CreatedAt).IsRequired();

            builder.HasOne(d => d.User)
                   .WithOne(u => u.Doctor)
                   .HasForeignKey<Doctor>(d => d.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Specialization)
                   .WithMany(s => s.Doctors)
                   .HasForeignKey(d => d.SpecializationId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
