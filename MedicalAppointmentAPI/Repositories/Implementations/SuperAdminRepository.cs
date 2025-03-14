
using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.Services.Interfaces;


namespace MedicalAppointmentAPI.Repositories.Implementations;


public class SuperAdminRepository : ISuperAdminRepository
{
    private readonly ApplicationDbContext _context; 
    
    public SuperAdminRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
}