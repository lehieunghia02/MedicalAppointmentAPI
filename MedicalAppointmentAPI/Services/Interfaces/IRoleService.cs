using MedicalAppointmentAPI.DTOs.Role;
using MedicalAppointmentAPI.Models;

namespace MedicalAppointmentAPI.Services.Interfaces;

public interface IRoleService
{
    Task<List<RoleDto>> GetAllRolesAsync();
    Task<(List<ApplicationUser> Users, int TotalCount)> GetUsersByRoleNameAsync(string roleName, int page, int pageSize);
}