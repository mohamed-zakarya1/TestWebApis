using Assn.Dtos.DoctorDtos;

namespace Assn.Dtos.AppointmentsDtos
{
    public class GetAllApssWithoutPatients
    {
        public DateTime? Date { get; set; }
        public GetDoctorsWithout? Doctor { get; set; }
    }
}
