using Assn.Dtos.DoctorDtos;
using Assn.Dtos.PatientDtos;
using Assn.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assn.Dtos.AppointmentsDtos
{
    public class GetAllApps
    {
        public DateTime? Date { get; set; }
        public GetDoctorsWithout? Doctor { get; set; }
        public GetAllPatientsWithoutApps? Patient { get; set; }
    }
}
