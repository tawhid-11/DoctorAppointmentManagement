using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        
    }
}
