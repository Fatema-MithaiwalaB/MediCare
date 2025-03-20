using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class PatientNoteConfiguration : IEntityTypeConfiguration<PatientNote>
    {
        public void Configure(EntityTypeBuilder<PatientNote> builder)
        {
            builder.HasKey(pn => pn.PatientNoteId);
            builder.Property(pn => pn.NoteText).IsRequired().HasMaxLength(1000);
            builder.Property(pn => pn.CreatedBy).IsRequired();
            builder.Property(pn => pn.CreatedAt).IsRequired();

            builder.HasOne(pn => pn.Appointment)
                   .WithMany(a => a.PatientNotes)
                   .HasForeignKey(pn => pn.AppointmentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
