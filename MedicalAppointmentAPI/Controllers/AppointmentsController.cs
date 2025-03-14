using MedicalAppointmentAPI.Common.Constants;
using MedicalAppointmentAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedicalAppointmentAPI.Controllers;

[Authorize(Policy = SystemConstants.Policies.RequirePatient)]
[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;
    private readonly ILogger<AppointmentsController> _logger;
    public AppointmentsController(
        IAppointmentService appointmentService, 
        ILogger<AppointmentsController> logger)
    {
        _appointmentService = appointmentService;
        _logger = logger; 
    }
    
    
}