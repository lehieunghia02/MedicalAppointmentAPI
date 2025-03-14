using MedicalAppointmentAPI.DTOs.Appointments;
using MedicalAppointmentAPI.DTOs.Paginations;

namespace MedicalAppointmentAPI.Services.Interfaces
{
  public interface IAppointmentService
  {
    // Get all appointments with pagination and filtering
    Task<PaginationResult<AppointmentDto>> GetAppointmentsAsync(AppointmentFilterDto filterDto);

    // Get appointment details by ID
    Task<AppointmentDetailDto> GetAppointmentByIdAsync(int id);

    // Create a new appointment
    Task<AppointmentDetailDto> CreateAppointmentAsync(CreateAppointmentDto createDto);

    // Update appointment information
    Task<AppointmentDetailDto> UpdateAppointmentAsync(int id, UpdateAppointmentDto updateDto);

    // Delete an appointment
    Task DeleteAppointmentAsync(int id);

    // Update appointment status
    Task<AppointmentDetailDto> UpdateAppointmentStatusAsync(int id, UpdateAppointmentStatusDto statusDto);

    // Get appointments for a specific doctor
    Task<PaginationResult<AppointmentDto>> GetDoctorAppointmentsAsync(int doctorId, AppointmentFilterDto filterDto);

    // Get appointments for a specific patient
    Task<PaginationResult<AppointmentDto>> GetPatientAppointmentsAsync(int patientId, AppointmentFilterDto filterDto);

    // Get appointments for a specific date
    Task<List<AppointmentDto>> GetAppointmentsByDateAsync(DateTime date);

    // Get upcoming appointments
    Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync(int count);
  }
}