using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Status { get; set; } = "Available"; // e.g., "Available", "Booked", "Unavailable"

    }
}
