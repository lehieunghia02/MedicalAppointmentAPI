using System.ComponentModel.DataAnnotations;

namespace Models;
/// <summary>
/// Table store day of week for doctor schedule
/// </summary>
public class WeekDay : BaseEntity
{
  public int Id { get; set; }

  //Name of day of week
  [Required]
  [StringLength(50)]
  public string Name { get; set; } = string.Empty;

  //Name day of week in vietnamese
  [Required]
  [StringLength(20)]
  public string ViName { get; set; } = string.Empty; // Thứ Hai, Thứ Ba, Thứ Tư, Thứ Năm, Thứ Sáu, Thứ Bảy, Chủ Nhật

  //Short name of day of week
  [Required]
  [StringLength(10)]
  public string ShortName { get; set; } = string.Empty; // Mon, Tue, Wed, Thu, Fri, Sat, Sun

  // is weekend day of week 
  public bool IsWeekend { get; set; }

  //Status of day of week
  public bool IsActive { get; set; } = true;
  //Navigation property
  public virtual ICollection<DoctorSchedule> DoctorSchedules { get; set; }
}