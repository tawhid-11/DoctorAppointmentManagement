using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentManagement.Models;
public class Review
{
    [Key]
    public int review_Id { get; set; }
    public int A_Id { get; set; }
    public int D_Id { get; set; }
    public int P_Id { get; set; }
    public int Rating { get; set; } // Rating out of 5
    public string Comments { get; set; } = string.Empty;

    // Navigation properties
    public Appointment Appointment { get; set; }
    public User Doctor { get; set; }
    public User Patient { get; set; }
    public Review() { }

    public Review(int appointmentId, int doctorId, int patientId, int rating, string comments)
    {
        A_Id = appointmentId;
        D_Id = doctorId;
        P_Id = patientId;
        Rating = rating;
        Comments = comments;
    }
}
