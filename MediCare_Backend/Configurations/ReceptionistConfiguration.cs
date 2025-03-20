using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class ReceptionistConfiguration : IEntityTypeConfiguration<Receptionist>
    {
        public void Configure(EntityTypeBuilder<Receptionist> builder)
        {
            builder.HasKey(r => r.ReceptionistId);
            builder.Property(r => r.Qualification).IsRequired().HasMaxLength(100);
            builder.Property(r => r.CreatedAt).IsRequired();

            builder.HasOne(r => r.User)
                   .WithOne(u => u.Receptionist)
                   .HasForeignKey<Receptionist>(r => r.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
