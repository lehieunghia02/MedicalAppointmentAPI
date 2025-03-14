using MedicalAppointmentAPI.DTOs.Doctor;
using MedicalAppointmentAPI.DTOs.Paginations;

namespace MedicalAppointmentAPI.Services.Interfaces;

public interface IDoctorService
{
  // Get all doctors with pagination and filtering
  Task<PaginationResult<DoctorDto>> GetDoctorsAsync(DoctorFilterDto filterDto);

  // Get doctor details by ID
  Task<DoctorDetailDto> GetDoctorByIdAsync(int id);

  // Create a new doctor
  Task<DoctorDetailDto> CreateDoctorAsync(CreateDoctorDto createDto);

  // Update doctor information
  Task<DoctorDetailDto> UpdateDoctorAsync(int id, UpdateDoctorDto updateDto);

  // Delete a doctor
  Task DeleteDoctorAsync(int id);

  // Get doctors by specialty
  Task<PaginationResult<DoctorDto>> GetDoctorsBySpecialtyAsync(int specialtyId, PaginationRequestDto paginationDto);

  // Get available doctors for a specific date/time
  Task<List<DoctorDto>> GetAvailableDoctorsAsync(AvailabilityRequestDto availabilityDto);

  // Add doctor schedule
  Task<DoctorScheduleDto> AddDoctorScheduleAsync(int doctorId, CreateDoctorScheduleDto scheduleDto);

  // Update doctor schedule
  Task<DoctorScheduleDto> UpdateDoctorScheduleAsync(int doctorId, int scheduleId, UpdateDoctorScheduleDto scheduleDto);

  // Delete doctor schedule
  Task DeleteDoctorScheduleAsync(int doctorId, int scheduleId);
}