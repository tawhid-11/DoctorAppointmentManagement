using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models
{
    public class Speciality
    {
        public Speciality() { }
        [Key] public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
