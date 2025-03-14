using System.ComponentModel.DataAnnotations;

namespace MedicalAppointmentAPI.DTOs.Roles;

/// <summary>
/// Dto for assigning a role to a user
/// </summary>
public class AssignRoleDto
{
    /// <summary>
    /// User Id
    /// </summary>
    [Required(ErrorMessage = "User ID is required")]
    public Guid UserId { get; set; }
    
    [Required(ErrorMessage = "Role ID is required")]
    public Guid RoleId { get; set; }
    
}