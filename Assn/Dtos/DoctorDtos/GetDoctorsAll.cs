using Assn.Dtos.AppointmentsDtos;
using Assn.Models;

namespace Assn.Dtos.DoctorDtos
{
    public class GetDoctorsAll
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public IList<GetAppWithoutDoctors>? Appointments { get; set; }
    }
}
