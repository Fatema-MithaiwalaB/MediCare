using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Models
{
    [Index(nameof(RoleName), IsUnique = true, Name = "IX_RoleName_Unique")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
