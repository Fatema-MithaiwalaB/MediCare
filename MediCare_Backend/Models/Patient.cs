using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MediCare_Backend.Models
{
    [Index(nameof(AadharNo), IsUnique = true)]
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string AadharNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
