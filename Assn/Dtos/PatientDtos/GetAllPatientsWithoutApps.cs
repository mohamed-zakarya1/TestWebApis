using Assn.Dtos.MedicineDtos;
using Assn.Dtos.PrescriptionDtos;
using Assn.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assn.Dtos.PatientDtos
{
    public class GetAllPatientsWithoutApps
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public PrescriptionDto? Prescription { get; set; }
        public int? PrescriptionId { get; set; }
        public IList<GetAllMedicinesWithoutPatients>? Medicines { get; set; }
    }
}
