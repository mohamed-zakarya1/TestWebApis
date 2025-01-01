using Assn.Dtos.AppointmentsDtos;
using Assn.Dtos.PrescriptionDtos;
using Assn.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assn.Dtos.PatientDtos
{
    public class GetAllWithoutMedicine
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public IList<GetAllApssWithoutPatients>? Appointments { get; set; }
        [ForeignKey("PrescriptionId")]
        public PrescriptionDto? Prescription { get; set; }
        public int? PrescriptionId { get; set; }
    }
}
