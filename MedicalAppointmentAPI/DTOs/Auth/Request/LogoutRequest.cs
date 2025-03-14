namespace MedicalAppointmentAPI.DTOs.Auth.Request; 
public class LogoutRequest 
{
  public string RefreshToken {get;set;} = string.Empty;
}