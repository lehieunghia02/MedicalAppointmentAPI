namespace DTOs.Doctor.Responses;

public class DoctorResponse
{
  public int Id { get; set; }
  public string UserId { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string FullName { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }
  public string Specialty { get; set; }
  public string License { get; set; }
  // public string ClinicName { get; set; }
  public string AvatarUrl { get; set; }
  public bool IsAvailable { get; set; }
}