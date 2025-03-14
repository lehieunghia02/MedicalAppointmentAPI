using Microsoft.AspNetCore.Authorization;
using MedicalAppointmentAPI.Common.Configurations.Authorization.Requirements;

namespace MedicalAppointmentAPI.Common.Configurations.Authorization.Handlers;

public class RoleHandler : AuthorizationHandler<RoleRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        RoleRequirement requirement)
    {
        if (context.User.IsInRole(requirement.Role))
        {
            context.Succeed(requirement);
        }
        
        return Task.CompletedTask;
    }
}