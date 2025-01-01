using Assn.Dtos.DoctorDtos;
using Assn.Dtos.PatientDtos;

namespace Assn.Dtos.AppointmentsDtos
{
    public class GetAppWithoutDoctors
    {
        public DateTime? Date { get; set; }
        public GetAllPatientsWithoutApps? Patient { get; set; }
    }
}
