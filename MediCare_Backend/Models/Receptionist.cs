using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MediCare_Backend.Models
{
    public class Receptionist
    {
        [Key]
        public int ReceptionistId { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public string Qualification { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
