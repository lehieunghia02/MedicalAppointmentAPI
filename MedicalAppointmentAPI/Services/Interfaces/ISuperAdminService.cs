using MedicalAppointmentAPI.DTOs.Patients;

namespace MedicalAppointmentAPI.Services.Interfaces;

public interface ISuperAdminService
{
  Task<(List<PatientDto> patients, int totalCount)> GetPatientsAsync(int page, int pageSize);
}