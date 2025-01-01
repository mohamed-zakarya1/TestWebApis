using Assn.Data;
using Assn.Dtos.AppointmentsDtos;
using Assn.Dtos.DoctorDtos;
using Assn.Dtos.MedicineDtos;
using Assn.Dtos.PatientDtos;
using Assn.Dtos.PrescriptionDtos;
using Assn.Models;
using Microsoft.EntityFrameworkCore;

namespace Assn.Repos.DoctorsRepo
{
    public class DoctorRepo : IDoctorsRepo
    {
        private readonly AppDbContext _context;
        public DoctorRepo(AppDbContext context) 
        {
            _context = context;
        }
        public void AddAll(GetDoctorsAll dto)
        {
            var docs = new Doctor
            {
                Name = dto.Name,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Appointments = dto.Appointments.Select(x => new Appointment
                {
                    Date = x.Date,
                    Patient = new Patient
                    {
                        Email = x.Patient.Email,
                        Name = x.Patient.Name,
                        PhoneNumber = x.Patient.PhoneNumber,
                        Prescription = new Prescription
                        {
                            Name = x.Patient.Prescription.Name
                        },
                        Medicines = x.Patient.Medicines.Select(x => new Medicine
                        {
                            Name = x.Name
                        }).ToList()
                    }
                }).ToList(),
            };
            _context.Doctors.Add(docs);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var doctors = _context.Doctors.Include(x => x.Appointments).ThenInclude(x => x.Patient).ThenInclude(x => x.Medicines).ThenInclude(x => x.Patients).ThenInclude(x => x.Prescription).FirstOrDefault(x => x.Id == id);
            _context.Remove(doctors);
            _context.SaveChanges();
        }

        public IList<GetDoctorsAll> GetAll()
        {
            var doctors = _context.Doctors.Include(x => x.Appointments).ThenInclude(x => x.Patient).ThenInclude(x => x.Medicines).ThenInclude(x => x.Patients).ThenInclude(x => x.Prescription).Select(x => new GetDoctorsAll
            {
                Name = x.Name,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Appointments = x.Appointments.Select(x => new GetAppWithoutDoctors
                {
                    Date = x.Date,
                    Patient = new GetAllPatientsWithoutApps
                    {
                        Email = x.Patient.Email,
                        PhoneNumber = x.Patient.PhoneNumber,
                        Name = x.Patient.Name,
                        Prescription = new PrescriptionDto
                        {
                            Name = x.Patient.Prescription.Name
                        },
                        Medicines = x.Patient.Medicines.Select(x=> new GetAllMedicinesWithoutPatients
                        {
                            Name = x.Name,
                        }).ToList()
                    },
                }).ToList(),
            }).ToList();
            return doctors;
        }

        public GetDoctorsAll GetById(int id)
        {
            var doctors = _context.Doctors.Include(x => x.Appointments).ThenInclude(x => x.Patient).ThenInclude(x => x.Medicines).ThenInclude(x => x.Patients).ThenInclude(x => x.Prescription).FirstOrDefault(x => x.Id == id);
            return new GetDoctorsAll
            {
                Name = doctors.Name,
                Email = doctors.Email,
                PhoneNumber = doctors.PhoneNumber,
                Appointments = doctors.Appointments.Select(x => new GetAppWithoutDoctors
                {
                    Date = x.Date,
                    Patient = new GetAllPatientsWithoutApps
                    {
                         Email = x.Patient.Email,
                         PhoneNumber = x.Patient.PhoneNumber,
                         Name = x.Patient.Name,
                         Prescription = new PrescriptionDto
                         {
                             Name = x.Patient.Prescription.Name
                         },
                         Medicines = x.Patient.Medicines.Select(x => new GetAllMedicinesWithoutPatients
                         {
                             Name = x.Name
                         }).ToList()
                    }
                }).ToList()
            };
        }

        public void Update(GetDoctorsAll dto, int id)
        {
            var doctors = _context.Doctors.Include(x => x.Appointments).ThenInclude(x => x.Patient).ThenInclude(x => x.Medicines).ThenInclude(x => x.Patients).ThenInclude(x => x.Prescription).FirstOrDefault(x => x.Id == id);
            doctors.Name = dto.Name;
            doctors.Email = dto.Email;
            doctors.PhoneNumber = dto.PhoneNumber;
            doctors.Appointments = dto.Appointments.Select(x => new Appointment
            {
                Date = x.Date,
                Patient = new Patient
                {
                    Email = x.Patient.Email,
                    Name = x.Patient.Name,
                    PhoneNumber = x.Patient.PhoneNumber,
                    Prescription = new Prescription
                    {
                        Name = x.Patient.Prescription.Name,
                    },
                    Medicines = x.Patient.Medicines.Select(x => new Medicine
                    {
                        Name = x.Name
                    }).ToList()
                },
            }).ToList();
            _context.Doctors.Update(doctors);
            _context.SaveChanges();
        }
    }
}
