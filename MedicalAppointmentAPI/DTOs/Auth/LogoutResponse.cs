namespace MedicalAppointmentAPI.DTOs.Auth;
public class LogoutResponse 
{
  public int Status {get;set;}
  public string Message {get; set;} = string.Empty; 
  public LogoutData? Data {get;set;}
  public class LogoutData
  {
    public bool Succeeded {get;set;} 
    public string Message { get; set; } = string.Empty;
    public DateTime LogoutTime { get; set; } = DateTime.UtcNow;
  }
}
