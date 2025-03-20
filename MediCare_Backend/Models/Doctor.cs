using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MediCare_Backend.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int SpecializationId { get; set; }
        [ForeignKey("SpecializationId")]
        public virtual Specialization Specialization { get; set; }
        public string Qualification { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
