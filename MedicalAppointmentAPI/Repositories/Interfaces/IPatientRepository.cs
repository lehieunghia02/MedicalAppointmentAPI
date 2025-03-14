using MedicalAppointmentAPI.DTOs.Patients;

namespace MedicalAppointmentAPI.Repositories.Interfaces;

public interface IPatientRepository
{
    Task<List<PatientDto>> GetPatientsAsync(int skip, int take);
    Task<int> GetPatientsCountAsync();
}