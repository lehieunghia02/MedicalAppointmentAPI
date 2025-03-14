using MedicalAppointmentAPI.DTOs.Patients;
using MedicalAppointmentAPI.Repositories.Interfaces;
using MedicalAppointmentAPI.Services.Interfaces;

namespace MedicalAppointmentAPI.Services.Implementations;

public class SuperAdminService : ISuperAdminService
{
    private readonly IPatientRepository _patientRepository;
    private readonly ILogger<SuperAdminService> _logger;

    public  SuperAdminService(IPatientRepository patientRepository, ILogger<SuperAdminService> logger)
    {
        _patientRepository = patientRepository;
        _logger = logger;
    }   
  
    public async Task<(List<PatientDto> patients, int totalCount)> GetPatientsAsync(int page, int pageSize)
    {
        
        int skip = (page - 1) * pageSize;
        
        var patients = await _patientRepository.GetPatientsAsync(skip, pageSize);
        var totalCount = await _patientRepository.GetPatientsCountAsync();
        return (patients, totalCount); 
    }
}
