using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Doctor
{
  /// <summary>
  /// DTO for updating doctor information
  /// </summary>
  public class UpdateDoctorDto
  {
    [Required(ErrorMessage = "Full name is required")]
    [StringLength(100, ErrorMessage = "Full name cannot exceed 100 characters")]
    public string FullName { get; set; }

    [Phone(ErrorMessage = "Invalid phone number format")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Specialty ID is required")]
    public int SpecialtyId { get; set; }

    public string ProfileImage { get; set; }

    [StringLength(1000, ErrorMessage = "Biography cannot exceed 1000 characters")]
    public string Biography { get; set; }

    [StringLength(500, ErrorMessage = "Education cannot exceed 500 characters")]
    public string Education { get; set; }

    [StringLength(500, ErrorMessage = "Experience cannot exceed 500 characters")]
    public string Experience { get; set; }

    [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
    public string Address { get; set; }

    public int? ClinicId { get; set; }

    public bool IsAvailable { get; set; }
  }
}