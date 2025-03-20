using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.AppointmentId);

            builder.Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.AppointmentStarts)
                .IsRequired();  

            builder.Property(a => a.AppointmentEnds)
                .IsRequired();

            builder.Property(a => a.AppointmentDescription).HasMaxLength(500);

            builder.Property(a => a.CreatedBy)
                .HasMaxLength(100);

            builder.Property(a => a.CreatedAt)
                .IsRequired();

            builder.Property(a => a.UpdatedBy)
                .HasMaxLength(100);

            builder.Property(a => a.UpdatedAt)
                .IsRequired(false);

            builder.HasOne(a => a.Patient)
                   .WithMany(p => p.Appointments)
                   .HasForeignKey(a => a.PatientId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Doctor)
                   .WithMany(d => d.Appointments)
                   .HasForeignKey(a => a.DoctorId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
