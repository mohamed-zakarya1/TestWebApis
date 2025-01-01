using System.ComponentModel.DataAnnotations.Schema;

namespace Assn.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public IList<Appointment>? Appointments { get; set; }
        [ForeignKey("PrescriptionId")]
        public Prescription? Prescription { get; set; }
        public int? PrescriptionId { get; set; }
        public IList<Medicine>? Medicines { get; set; }
    }
}
