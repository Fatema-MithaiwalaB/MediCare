using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime? DateOfRelieving { get; set; }
        public string MobileNo { get; set; }
        public string EmergencyNo { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        //optional one to one relationship to specialized profiles
        public virtual Doctor? Doctor { get; set; }  
        public virtual Receptionist? Receptionist { get; set; }
    }
}
