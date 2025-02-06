using System.ComponentModel.DataAnnotations;
using MedicalAppointmentAPI.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace Models;
public class DoctorSchedule : BaseEntity
{
  public int Id { get; set; }


  //Link to doctor
  public int DoctorId { get; set; }
  public Doctor Doctor { get; set; }

  //Day of week
  [Required]
  public int WeekDayId { get; set; }
  public WeekDay WeekDay { get; set; }

  //Time start
  public TimeSpan StartTime { get; set; }

  //Time end 
  [Required]
  [DataType(DataType.Time)]
  public TimeSpan EndTime { get; set; }

  //Size of patient can be appointment in slot time 
  [Range(1, 100)]
  public int MaxAppointments { get; set; } = 20;

  //Average time cho mỗi ca khám 
  [Range(10, 200)]
  public int AverageConsultingTime { get; set; } = 30;


  // Time break between each appointment (minutes)
  [Range(0, 60)]
  public int BreakTime { get; set; } = 5;

  //Navigation property 
  public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

}