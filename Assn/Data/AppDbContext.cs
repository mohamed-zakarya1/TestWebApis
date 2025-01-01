using Assn.Models;
using Microsoft.EntityFrameworkCore;

namespace Assn.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}
        public DbSet<Doctor>? Doctors { get; set; }
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }
        public DbSet<Medicine>? Medicines { get; set; }
        public DbSet<Prescription>? Prescriptions { get; set; }
    }
}
