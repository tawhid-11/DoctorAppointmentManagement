using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models
{
    public class Patient
    {
        [Key]
        public int p_id { get; set; }
        public string P_tName { get; set; }
            public string P_Description { get; set; }
            public string P_C_Number { get; set; }
            public string P_Email { get; set; }
            public string P_Address { get; set; }
        public string P_BloodGroup { get; set; } 
        public string Gender { get; set; }
        public string P_DoB { get; set; }


    }
}
