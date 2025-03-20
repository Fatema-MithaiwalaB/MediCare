using MediCare_Backend.Configurations;
using MediCare_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace MediCare_Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<PatientNote> PatientNotes { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new SpecializationConfiguration());
            modelBuilder.ApplyConfiguration(new PatientNoteConfiguration());
            modelBuilder.ApplyConfiguration(new ReceptionistConfiguration());
        }
    }
}
