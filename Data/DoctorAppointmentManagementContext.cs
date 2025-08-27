using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoctorAppointmentManagement.Models;

namespace DoctorAppointmentManagement.Data
{
    public class DoctorAppointmentManagementContext : DbContext
    {
        public DoctorAppointmentManagementContext (DbContextOptions<DoctorAppointmentManagementContext> options)
            : base(options)
        {
        }

        public DbSet<DoctorAppointmentManagement.Models.Doctor> Doctor { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.Patient> Patient { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.Admin> Admin { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.Appointment> Appointment { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.Review> Review { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.Schedule> Schedule { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.Speciality> Speciality { get; set; } = default!;
        public DbSet<DoctorAppointmentManagement.Models.User> User { get; set; } = default!;
    }
}
