using MedicalAppointmentAPI.DTOs.Role;
using MedicalAppointmentAPI.DTOs.Users;
using MedicalAppointmentAPI.Models;

namespace MedicalAppointmentAPI.Repositories.Interfaces;

public interface IRoleRepository
{
    Task<List<RoleDto>> GetRolesAsync();
    Task<(List<ApplicationUser> Users, int TotalCount)> GetUsersByRoleNameAsync(string roleName, int page, int pageSize);
}