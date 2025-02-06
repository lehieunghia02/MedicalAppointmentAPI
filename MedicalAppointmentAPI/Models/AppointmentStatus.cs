//Trạng thái lịch hẹn 
using System.ComponentModel.DataAnnotations;

namespace Models;
/// <summary>
/// Table lưu trạng thái của lịch hẹn
/// </summary>
public class AppointmentStatus : BaseEntity
{
  public int Id { get; set; }
  [Required]
  [StringLength(50)]
  public string Name { get; set; } = string.Empty;
  [StringLength(255)]
  public string? Description { get; set; }
  public bool IsActive { get; set; } = true;

  //Navigation property 
  public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

}