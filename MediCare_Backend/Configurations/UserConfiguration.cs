using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.MobileNo).IsUnique();

            builder.Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(255);

            builder.Property(u => u.MobileNo)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(u => u.EmergencyNo)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(u => u.RoleId)
                .IsRequired();

            builder.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(u => u.Active)
                .IsRequired();

            builder.Property(u => u.CreatedBy)
                .IsRequired();

            builder.Property(u=> u.CreatedAt)
                .IsRequired();

            builder.Property(u => u.UpdatedBy)
                .IsRequired(false);

            builder.Property(u => u.UpdatedAt)
                .IsRequired(false);

        }
    }
}
