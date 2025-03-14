using MedicalAppointmentAPI.Data;
using MedicalAppointmentAPI.DTOs.Doctor;
using MedicalAppointmentAPI.DTOs.Paginations;
using MedicalAppointmentAPI.Models;
using MedicalAppointmentAPI.Repositories.Interfaces;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace MedicalAppointmentAPI.Services.Implementations
{
  /// <summary>
  /// Service for managing doctors
  /// </summary>
  public class DoctorService : IDoctorService
  {
    private readonly IBaseRepository<Doctor> _doctorRepository;
    private readonly IBaseRepository<DoctorSchedule> _scheduleRepository;
    private readonly IBaseRepository<Specialty> _specialtyRepository;
    private readonly IBaseRepository<Clinic> _clinicRepository;
    private readonly IBaseRepository<Appointment> _appointmentRepository;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _dbContext;

    public DoctorService(
        IBaseRepository<Doctor> doctorRepository,
        IBaseRepository<DoctorSchedule> scheduleRepository,
        IBaseRepository<Specialty> specialtyRepository,
        IBaseRepository<Clinic> clinicRepository,
        IBaseRepository<Appointment> appointmentRepository,
        UserManager<ApplicationUser> userManager,
        ApplicationDbContext dbContext)
    {
      _doctorRepository = doctorRepository;
      _scheduleRepository = scheduleRepository;
      _specialtyRepository = specialtyRepository;
      _clinicRepository = clinicRepository;
      _appointmentRepository = appointmentRepository;
      _userManager = userManager;
      _dbContext = dbContext;
    }

    /// <summary>
    /// Get all doctors with pagination and filtering
    /// </summary>
    public async Task<PaginationResult<DoctorDto>> GetDoctorsAsync(DoctorFilterDto filterDto)
    {
      // Build the query with filters
      var query = _doctorRepository.Query()
          .Include(d => d.Specialty)
          .Include(d => d.Clinic)
          .Include(d => d.User)
          .AsQueryable();

      // Apply filters
      if (!string.IsNullOrWhiteSpace(filterDto.SearchTerm))
      {
        var searchTerm = filterDto.SearchTerm.ToLower();
        query = query.Where(d =>
            d.User.FullName.ToLower().Contains(searchTerm) ||
            d.User.Email.ToLower().Contains(searchTerm) ||
            d.User.PhoneNumber.Contains(searchTerm));
      }

      if (filterDto.SpecialtyId.HasValue)
      {
        query = query.Where(d => d.SpecialtyId == filterDto.SpecialtyId.Value);
      }

      if (filterDto.ClinicId.HasValue)
      {
        query = query.Where(d => d.ClinicId == filterDto.ClinicId.Value);
      }

      if (filterDto.IsAvailable.HasValue)
      {
        query = query.Where(d => d.IsAvailable == filterDto.IsAvailable.Value);
      }

      // Apply sorting
      query = ApplySorting(query, filterDto.SortBy, filterDto.SortDirection);

      // Get total count
      var totalCount = await query.CountAsync();

      // Apply pagination
      var doctors = await query
          .Skip((filterDto.PageNumber - 1) * filterDto.PageSize)
          .Take(filterDto.PageSize)
          .ToListAsync();

      // Map to DTOs
      var doctorDtos = doctors.Select(d => new DoctorDto
      {
        Id = d.Id,
        FullName = d.User.FullName,
        Email = d.User.Email,
        PhoneNumber = d.User.PhoneNumber,
        SpecialtyName = d.Specialty?.Name,
        SpecialtyId = d.SpecialtyId,
        ProfileImage = d.User.AvatarUrl,
        IsAvailable = d.IsAvailable
      }).ToList();

      // Create pagination result
      return new PaginationResult<DoctorDto>
      {
        PageNumber = filterDto.PageNumber,
        PageSize = filterDto.PageSize,
        TotalCount = totalCount,
        Items = doctorDtos
      };
    }

    /// <summary>
    /// Get doctor details by ID
    /// </summary>
    public async Task<DoctorDetailDto> GetDoctorByIdAsync(int id)
    {
      var doctor = await _doctorRepository.Query()
          .Include(d => d.Specialty)
          .Include(d => d.Clinic)
          .Include(d => d.User)
          .Include(d => d.Schedules)
          .FirstOrDefaultAsync(d => d.Id == id);

      if (doctor == null)
      {
        throw new KeyNotFoundException($"Doctor with ID {id} not found");
      }

      return new DoctorDetailDto
      {
        Id = doctor.Id,
        FullName = doctor.User.FullName,
        Email = doctor.User.Email,
        PhoneNumber = doctor.User.PhoneNumber,
        SpecialtyName = doctor.Specialty?.Name,
        SpecialtyId = doctor.SpecialtyId,
        ProfileImage = doctor.User.AvatarUrl,
        IsAvailable = doctor.IsAvailable,
        Biography = doctor.Biography,
        Education = doctor.Qualifications,
        Experience = doctor.YearsOfExperience.ToString(),
        Address = doctor.User.Address,
        ClinicId = doctor.ClinicId,
        ClinicName = doctor.Clinic?.Name,
        Schedules = doctor.Schedules.Select(s => new DoctorScheduleDto
        {
          Id = s.Id,
          DoctorId = s.DoctorId,
          DayOfWeek = s.WeekDay.ToString(),
          StartTime = s.StartTime,
          EndTime = s.EndTime,
          IsAvailable = s.MaxAppointments > 0
        }).ToList()
      };
    }

    /// <summary>
    /// Create a new doctor
    /// </summary>
    public async Task<DoctorDetailDto> CreateDoctorAsync(CreateDoctorDto createDto)
    {
      // Check if specialty exists
      var specialty = await _specialtyRepository.GetByIdAsync(createDto.SpecialtyId);
      if (specialty == null)
      {
        throw new KeyNotFoundException($"Specialty with ID {createDto.SpecialtyId} not found");
      }

      // Check if clinic exists if provided
      if (createDto.ClinicId.HasValue)
      {
        var clinic = await _clinicRepository.GetByIdAsync(createDto.ClinicId.Value);
        if (clinic == null)
        {
          throw new KeyNotFoundException($"Clinic with ID {createDto.ClinicId} not found");
        }
      }

      // Check if email is already in use
      var existingUser = await _userManager.FindByEmailAsync(createDto.Email);
      if (existingUser != null)
      {
        throw new InvalidOperationException($"Email {createDto.Email} is already in use");
      }

      // Create user
      var user = new ApplicationUser
      {
        UserName = createDto.Email,
        Email = createDto.Email,
        PhoneNumber = createDto.PhoneNumber,
        FirstName = createDto.FullName.Split(' ')[0],
        LastName = string.Join(" ", createDto.FullName.Split(' ').Skip(1)),
        AvatarUrl = createDto.ProfileImage,
        Address = createDto.Address,
        EmailConfirmed = true
      };

      var result = await _userManager.CreateAsync(user, createDto.Password);
      if (!result.Succeeded)
      {
        throw new InvalidOperationException($"Failed to create user: {string.Join(", ", result.Errors.Select(e => e.Description))}");
      }

      // Assign doctor role
      await _userManager.AddToRoleAsync(user, "Doctor");

      // Create doctor
      var doctor = new Doctor
      {
        UserId = user.Id.ToString(),
        SpecialtyId = createDto.SpecialtyId,
        Biography = createDto.Biography,
        Qualifications = createDto.Education,
        YearsOfExperience = int.TryParse(createDto.Experience, out int exp) ? exp : 0,
        ClinicId = createDto.ClinicId ?? 1, // Default to clinic ID 1 if not provided
        IsAvailable = true,
        LicenseNumber = "TBD" // This is required, so providing a default
      };

      await _doctorRepository.AddAsync(doctor);
      await _dbContext.SaveChangesAsync();

      // Return created doctor
      return await GetDoctorByIdAsync(doctor.Id);
    }

    /// <summary>
    /// Update doctor information
    /// </summary>
    public async Task<DoctorDetailDto> UpdateDoctorAsync(int id, UpdateDoctorDto updateDto)
    {
      var doctor = await _doctorRepository.Query()
          .Include(d => d.User)
          .FirstOrDefaultAsync(d => d.Id == id);

      if (doctor == null)
      {
        throw new KeyNotFoundException($"Doctor with ID {id} not found");
      }

      // Check if specialty exists
      var specialty = await _specialtyRepository.GetByIdAsync(updateDto.SpecialtyId);
      if (specialty == null)
      {
        throw new KeyNotFoundException($"Specialty with ID {updateDto.SpecialtyId} not found");
      }

      // Check if clinic exists if provided
      if (updateDto.ClinicId.HasValue)
      {
        var clinic = await _clinicRepository.GetByIdAsync(updateDto.ClinicId.Value);
        if (clinic == null)
        {
          throw new KeyNotFoundException($"Clinic with ID {updateDto.ClinicId} not found");
        }
      }

      // Update user information
      doctor.User.FirstName = updateDto.FullName.Split(' ')[0];
      doctor.User.LastName = string.Join(" ", updateDto.FullName.Split(' ').Skip(1));
      doctor.User.PhoneNumber = updateDto.PhoneNumber;
      doctor.User.AvatarUrl = updateDto.ProfileImage;
      doctor.User.Address = updateDto.Address;

      // Update doctor information
      doctor.SpecialtyId = updateDto.SpecialtyId;
      doctor.Biography = updateDto.Biography;
      doctor.Qualifications = updateDto.Education;
      doctor.YearsOfExperience = int.TryParse(updateDto.Experience, out int exp) ? exp : 0;
      doctor.ClinicId = updateDto.ClinicId ?? 1; // Default to clinic ID 1 if not provided
      doctor.IsAvailable = updateDto.IsAvailable;

      await _doctorRepository.UpdateAsync(doctor);
      await _userManager.UpdateAsync(doctor.User);
      await _dbContext.SaveChangesAsync();

      // Return updated doctor
      return await GetDoctorByIdAsync(id);
    }

    /// <summary>
    /// Delete a doctor
    /// </summary>
    public async Task DeleteDoctorAsync(int id)
    {
      var doctor = await _doctorRepository.Query()
          .Include(d => d.User)
          .FirstOrDefaultAsync(d => d.Id == id);

      if (doctor == null)
      {
        throw new KeyNotFoundException($"Doctor with ID {id} not found");
      }

      // Check if doctor has appointments
      var hasAppointments = await _appointmentRepository.Query()
          .AnyAsync(a => a.DoctorId == id);

      if (hasAppointments)
      {
        throw new InvalidOperationException("Cannot delete doctor with existing appointments");
      }

      // Delete doctor schedules
      var schedules = await _scheduleRepository.Query()
          .Where(s => s.DoctorId == id)
          .ToListAsync();

      foreach (var schedule in schedules)
      {
        await _scheduleRepository.DeleteAsync(schedule.Id);
      }

      // Delete doctor
      await _doctorRepository.DeleteAsync(doctor.Id);

      // Delete user
      await _userManager.DeleteAsync(doctor.User);

      await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Get doctors by specialty
    /// </summary>
    public async Task<PaginationResult<DoctorDto>> GetDoctorsBySpecialtyAsync(int specialtyId, PaginationRequestDto paginationDto)
    {
      // Check if specialty exists
      var specialty = await _specialtyRepository.GetByIdAsync(specialtyId);
      if (specialty == null)
      {
        throw new KeyNotFoundException($"Specialty with ID {specialtyId} not found");
      }

      // Create filter DTO
      var filterDto = new DoctorFilterDto
      {
        SpecialtyId = specialtyId,
        PageNumber = paginationDto.PageNumber,
        PageSize = paginationDto.PageSize,
        SortBy = paginationDto.SortBy,
        SortDirection = paginationDto.SortDirection
      };

      // Get doctors by specialty
      return await GetDoctorsAsync(filterDto);
    }

    /// <summary>
    /// Get available doctors for a specific date/time
    /// </summary>
    public async Task<List<DoctorDto>> GetAvailableDoctorsAsync(AvailabilityRequestDto availabilityDto)
    {
      // Get day of week
      var dayOfWeek = (int)availabilityDto.Date.DayOfWeek;

      // Get doctors with schedules for the specified day
      var query = _doctorRepository.Query()
          .Include(d => d.Specialty)
          .Include(d => d.User)
          .Include(d => d.Schedules.Where(s => s.WeekDayId == dayOfWeek))
          .Where(d => d.IsAvailable && d.Schedules.Any(s =>
              s.WeekDayId == dayOfWeek &&
              s.MaxAppointments > 0 &&
              s.StartTime <= availabilityDto.StartTime &&
              s.EndTime >= availabilityDto.EndTime));

      // Filter by specialty if provided
      if (availabilityDto.SpecialtyId.HasValue)
      {
        query = query.Where(d => d.SpecialtyId == availabilityDto.SpecialtyId.Value);
      }

      // Get doctors
      var doctors = await query.ToListAsync();

      // Filter out doctors with conflicting appointments
      var availableDoctors = new List<Doctor>();
      foreach (var doctor in doctors)
      {
        // Check if doctor has appointments during the requested time
        var hasConflictingAppointment = await _appointmentRepository.Query()
            .AnyAsync(a =>
                a.DoctorId == doctor.Id &&
                a.AppointmentDate.Date == availabilityDto.Date.Date &&
                ((a.StartTime.TimeOfDay <= availabilityDto.StartTime && a.EndTime.TimeOfDay > availabilityDto.StartTime) ||
                 (a.StartTime.TimeOfDay < availabilityDto.EndTime && a.EndTime.TimeOfDay >= availabilityDto.EndTime) ||
                 (a.StartTime.TimeOfDay >= availabilityDto.StartTime && a.EndTime.TimeOfDay <= availabilityDto.EndTime)));

        if (!hasConflictingAppointment)
        {
          availableDoctors.Add(doctor);
        }
      }

      // Map to DTOs
      return availableDoctors.Select(d => new DoctorDto
      {
        Id = d.Id,
        FullName = d.User.FullName,
        Email = d.User.Email,
        PhoneNumber = d.User.PhoneNumber,
        SpecialtyName = d.Specialty?.Name,
        SpecialtyId = d.SpecialtyId,
        ProfileImage = d.User.AvatarUrl,
        IsAvailable = d.IsAvailable
      }).ToList();
    }

    /// <summary>
    /// Add doctor schedule
    /// </summary>
    public async Task<DoctorScheduleDto> AddDoctorScheduleAsync(int doctorId, CreateDoctorScheduleDto scheduleDto)
    {
      // Check if doctor exists
      var doctor = await _doctorRepository.GetByIdAsync(doctorId);
      if (doctor == null)
      {
        throw new KeyNotFoundException($"Doctor with ID {doctorId} not found");
      }

      // Check if schedule already exists for the day
      var existingSchedule = await _scheduleRepository.Query()
          .FirstOrDefaultAsync(s => s.DoctorId == doctorId && s.WeekDayId == scheduleDto.DayOfWeek);

      if (existingSchedule != null)
      {
        throw new InvalidOperationException($"Schedule for day {scheduleDto.DayOfWeek} already exists");
      }

      // Validate time range
      if (scheduleDto.EndTime <= scheduleDto.StartTime)
      {
        throw new InvalidOperationException("End time must be after start time");
      }

      // Create schedule
      var schedule = new DoctorSchedule
      {
        DoctorId = doctorId,
        WeekDayId = scheduleDto.DayOfWeek,
        StartTime = scheduleDto.StartTime,
        EndTime = scheduleDto.EndTime,
        MaxAppointments = 20 // Default value
      };

      await _scheduleRepository.AddAsync(schedule);
      await _dbContext.SaveChangesAsync();

      // Return created schedule
      return new DoctorScheduleDto
      {
        Id = schedule.Id,
        DoctorId = schedule.DoctorId,
        DayOfWeek = ((DayOfWeek)schedule.WeekDayId).ToString(),
        StartTime = schedule.StartTime,
        EndTime = schedule.EndTime,
        IsAvailable = schedule.MaxAppointments > 0
      };
    }

    /// <summary>
    /// Update doctor schedule
    /// </summary>
    public async Task<DoctorScheduleDto> UpdateDoctorScheduleAsync(int doctorId, int scheduleId, UpdateDoctorScheduleDto scheduleDto)
    {
      // Check if doctor exists
      var doctor = await _doctorRepository.GetByIdAsync(doctorId);
      if (doctor == null)
      {
        throw new KeyNotFoundException($"Doctor with ID {doctorId} not found");
      }

      // Check if schedule exists
      var schedule = await _scheduleRepository.Query()
          .FirstOrDefaultAsync(s => s.Id == scheduleId && s.DoctorId == doctorId);

      if (schedule == null)
      {
        throw new KeyNotFoundException($"Schedule with ID {scheduleId} not found for doctor {doctorId}");
      }

      // Validate time range
      if (scheduleDto.EndTime <= scheduleDto.StartTime)
      {
        throw new InvalidOperationException("End time must be after start time");
      }

      // Update schedule
      schedule.StartTime = scheduleDto.StartTime;
      schedule.EndTime = scheduleDto.EndTime;
      schedule.MaxAppointments = scheduleDto.IsAvailable ? 20 : 0; // Set max appointments based on availability

      await _scheduleRepository.UpdateAsync(schedule);
      await _dbContext.SaveChangesAsync();

      // Return updated schedule
      return new DoctorScheduleDto
      {
        Id = schedule.Id,
        DoctorId = schedule.DoctorId,
        DayOfWeek = ((DayOfWeek)schedule.WeekDayId).ToString(),
        StartTime = schedule.StartTime,
        EndTime = schedule.EndTime,
        IsAvailable = schedule.MaxAppointments > 0
      };
    }

    /// <summary>
    /// Delete doctor schedule
    /// </summary>
    public async Task DeleteDoctorScheduleAsync(int doctorId, int scheduleId)
    {
      // Check if doctor exists
      var doctor = await _doctorRepository.GetByIdAsync(doctorId);
      if (doctor == null)
      {
        throw new KeyNotFoundException($"Doctor with ID {doctorId} not found");
      }

      // Check if schedule exists
      var schedule = await _scheduleRepository.Query()
          .FirstOrDefaultAsync(s => s.Id == scheduleId && s.DoctorId == doctorId);

      if (schedule == null)
      {
        throw new KeyNotFoundException($"Schedule with ID {scheduleId} not found for doctor {doctorId}");
      }

      // Delete schedule
      await _scheduleRepository.DeleteAsync(scheduleId);
      await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Apply sorting to the query
    /// </summary>
    private IQueryable<Doctor> ApplySorting(IQueryable<Doctor> query, string sortBy, string sortDirection)
    {
      // Default sort by ID
      if (string.IsNullOrWhiteSpace(sortBy))
      {
        sortBy = "Id";
      }

      // Determine sort direction
      var isAscending = string.IsNullOrWhiteSpace(sortDirection) || sortDirection.ToLower() == "asc";

      // Apply sorting based on property
      switch (sortBy.ToLower())
      {
        case "fullname":
          return isAscending
              ? query.OrderBy(d => d.User.FullName)
              : query.OrderByDescending(d => d.User.FullName);
        case "email":
          return isAscending
              ? query.OrderBy(d => d.User.Email)
              : query.OrderByDescending(d => d.User.Email);
        case "specialty":
          return isAscending
              ? query.OrderBy(d => d.Specialty.Name)
              : query.OrderByDescending(d => d.Specialty.Name);
        case "clinic":
          return isAscending
              ? query.OrderBy(d => d.Clinic.Name)
              : query.OrderByDescending(d => d.Clinic.Name);
        case "isavailable":
          return isAscending
              ? query.OrderBy(d => d.IsAvailable)
              : query.OrderByDescending(d => d.IsAvailable);
        default:
          return isAscending
              ? query.OrderBy(d => d.Id)
              : query.OrderByDescending(d => d.Id);
      }
    }
  }
}
