using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models
{
    public class Appointment
    {
        [Key]
        public int A_Id { get; set; }
        public int P_Id { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } = "Scheduled"; // e.g., "Scheduled", "Completed", "Cancelled"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        // Navigation properties
        public User Patient { get; set; }
        public User Doctor { get; set; }
        public Speciality Speciality { get; set; }
    }
}
