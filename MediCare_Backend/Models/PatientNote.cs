using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MediCare_Backend.Models
{
    public class PatientNote
    {
        [Key]
        public int PatientNoteId { get; set; }
        public int AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; }
        public string NoteText { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
