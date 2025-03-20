using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Models
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }
        public string SpecializationName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
