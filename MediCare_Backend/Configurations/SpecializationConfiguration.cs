using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class SpecializationConfiguration : IEntityTypeConfiguration<Specialization>
    {
        public void Configure(EntityTypeBuilder<Specialization> builder)
        {
            builder.HasKey(s => s.SpecializationId);
            builder.Property(s => s.SpecializationName).IsRequired().HasMaxLength(100);
            builder.HasIndex(s => s.SpecializationName).IsUnique();

            builder.HasMany(s => s.Doctors)
                .WithOne(s => s.Specialization)
                .HasForeignKey(s => s.SpecializationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
