using Assn.Dtos.PatientDtos;
using Assn.Models;

namespace Assn.Dtos.MedicineDtos
{
    public class GetAllMedicines
    {
        public string? Name { get; set; }
        public IList<GetAllWithoutMedicine>? Patients { get; set; }
    }
}
