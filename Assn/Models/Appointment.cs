using System.ComponentModel.DataAnnotations.Schema;

namespace Assn.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
        public int? PatientId { get; set; }
    }
}
