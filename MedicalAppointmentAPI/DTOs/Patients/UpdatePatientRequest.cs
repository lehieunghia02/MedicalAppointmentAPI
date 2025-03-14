namespace HospitalManagement.DTOs.Patients
{
  public class UpdatePatientRequest
  {
    public string BloodType { get; set; } = string.Empty;
    public string Allergies { get; set; } = string.Empty;
    public string ChronicDiseases { get; set; } = string.Empty;
    public string InsuranceNumber { get; set; } = string.Empty;
  }
}
