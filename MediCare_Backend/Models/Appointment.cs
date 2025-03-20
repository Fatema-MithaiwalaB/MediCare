using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MediCare_Backend.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }
        public DateTime AppointmentStarts { get; set; }
        public DateTime AppointmentEnds { get; set; }
        public string Status { get; set; }
        public string AppointmentDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<PatientNote> PatientNotes { get; set; } = new List<PatientNote>();
    }
}
