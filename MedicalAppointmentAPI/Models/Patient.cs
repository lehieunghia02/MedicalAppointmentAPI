using MedicalAppointmentAPI.Models;

namespace Models;

public class Patient : BaseEntity
{
  public int Id { get; set; }

  //Khóa ngoại tới bảng ApplicationUser
  public string UserId { get; set; }
  public ApplicationUser User { get; set; }
  //Nhóm máu
  public string? BloodType { get; set; }
  //Dị ứng 
  public string? Allergies { set; get; }
  //Bệnh mãn tính
  public string? ChronicDiseases { set; get; }


  //Insurance (Insurance number)
  public string? InsuranceNumber { get; set; }
  public string? InsuranceProvider { get; set; }
  public DateTime? InsuranceExpiryDate { get; set; }

  //Navigation properties
  public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
  public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

}