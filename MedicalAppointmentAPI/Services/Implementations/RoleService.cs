using MedicalAppointmentAPI.DTOs.Role;
using MedicalAppointmentAPI.Models;
using MedicalAppointmentAPI.Repositories.Interfaces;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Services.Implementations;

public class RoleService : IRoleService
{
    private IRoleRepository _roleRepository;
    public RoleService(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<List<RoleDto>> GetAllRolesAsync()
    {
        return await _roleRepository.GetRolesAsync();
    }
    public async Task<(List<ApplicationUser> Users, int TotalCount)> GetUsersByRoleNameAsync(string roleName, int page, int pageSize)
    {
        return await _roleRepository.GetUsersByRoleNameAsync(roleName, page, pageSize);
    }
}