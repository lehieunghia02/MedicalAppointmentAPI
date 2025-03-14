using Models;

namespace MedicalAppointmentAPI.DTOs.Patients;

public class PatientDto : BaseEntity
{
     public int Id { get; set; } 
     public string FirstName { get; set; } =  string.Empty;
     public string LastName { get; set; } =  string.Empty;
     public string Email { get; set; } =  string.Empty;
     public string PhoneNumber { get; set; } =  string.Empty;
     public DateTime DateOfBirth { get; set; } = DateTime.Now;
     public string Gender { get; set; } =  string.Empty; 
     public string Address { get; set; } =  string.Empty; 
     public string MedicalHistory { get; set; } =  string.Empty;
     public string InsuranceInfo { get; set; } =  string.Empty;
     public string EmergencyContactName { get; set; } =  string.Empty;
     public string EmergencyContactPhone { get; set; }  =  string.Empty;
     public bool IsActive { get; set; }
}   