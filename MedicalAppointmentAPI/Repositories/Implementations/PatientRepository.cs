using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.Models;
using MedicalAppointmentAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MedicalAppointmentAPI.Repositories.Implementations;

public class PatientRepository : IPatientRepository
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<PatientRepository> _logger;

    public PatientRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
        ILogger<PatientRepository> logger)
    {
        _context = context;
        _userManager = userManager;
        _logger = logger;
    }

    public async Task<List<PatientDto>> GetPatientsAsync(int skip, int take)
    {
        return await _context.Patients.Skip(skip).Take(take).Select(p => new PatientDto
        {
            Id = p.Id,
            FirstName = p.User.FirstName,
            LastName = p.User.LastName,
            Email = p.User.Email ?? string.Empty,
            PhoneNumber = p.User.PhoneNumber ?? string.Empty,
            DateOfBirth = p.User.DateOfBirth,
            Gender = p.User.Gender.ToString(),
            Address = p.User.Address,
            InsuranceInfo = p.InsuranceNumber ?? string.Empty,
            CreatedAt = p.CreatedAt,
            UpdatedAt = p.UpdatedAt,
        }).ToListAsync();
    }

    public async Task<int> GetPatientsCountAsync()
    {
        return await _context.Patients.CountAsync();
    }
}