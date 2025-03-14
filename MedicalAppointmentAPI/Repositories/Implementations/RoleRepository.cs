using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.DTOs.Role;
using MedicalAppointmentAPI.DTOs.Users;
using MedicalAppointmentAPI.Models;
using MedicalAppointmentAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentAPI.Repositories.Implementations;

public class RoleRepository : IRoleRepository
{
    private readonly ApplicationDbContext _context;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public RoleRepository(ApplicationDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _roleManager = roleManager;
        _userManager = userManager;
    }
    public async Task<List<RoleDto>> GetRolesAsync()
    {
        var roles = await _context.Roles.ToListAsync();
        var roleDtos = roles.Select(role => new RoleDto
        {
            Id = role.Id,
            Name = role.Name
        }).ToList();
        return roleDtos;
    }



    public async Task<(List<ApplicationUser> Users, int TotalCount)> GetUsersByRoleNameAsync(string roleName, int page, int pageSize)
    {
        var role = await _roleManager.FindByNameAsync(roleName);
        if (role == null)
        {
            return (new List<ApplicationUser>(), 0);
        }

        var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name ?? string.Empty);
        var totalCount = usersInRole.Count;

        var users = usersInRole
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return (users, totalCount);
    }



}