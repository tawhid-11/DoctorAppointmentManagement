using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { get; set; }
        public string Designation { get; set; }
        public string AccessLevel { get; set; }
      
    }
}
