using Models;

namespace MedicalAppointmentAPI.DTOs.Role;

public class RoleDto : BaseEntity
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int UsersCount { get; set; } = 0; 
    public List<string> Permissions { get; set; } = new List<string>(); 
    
    public bool IsSystemRole { get; set; } 
}