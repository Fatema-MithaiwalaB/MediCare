using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediCare_Backend.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleId);
            builder.Property(r => r.RoleName)
                .IsRequired()  
                .HasMaxLength(50);
        }
    }
}
