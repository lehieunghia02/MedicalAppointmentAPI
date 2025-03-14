using Microsoft.AspNetCore.Authorization;

namespace MedicalAppointmentAPI.Common.Configurations.Authorization.Requirements;
public class RoleRequirement: IAuthorizationRequirement
{
  public string Role { get; }

    public RoleRequirement(string role)
    {
        Role = role;
    }
}