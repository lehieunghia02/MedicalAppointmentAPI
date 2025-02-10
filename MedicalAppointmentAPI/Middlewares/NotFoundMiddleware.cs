using System.Net;
using System.Text.Json;

namespace MedicalAppointmentAPI.Middleware;

public class NotFoundMiddleware
{
  private readonly RequestDelegate _next;
  private readonly ILogger<NotFoundMiddleware> _logger;

  public NotFoundMiddleware(RequestDelegate next, ILogger<NotFoundMiddleware> logger)
  {
    _next = next;
    _logger = logger;
  }

  public async Task InvokeAsync(HttpContext context)
  {
    await _next(context);

    if (context.Response.StatusCode == (int)HttpStatusCode.NotFound)
    {
      context.Response.ContentType = "application/json";

      var response = new
      {
        StatusCode = 404,
        Message = "The requested resource was not found"
      };

      var json = JsonSerializer.Serialize(response);
      await context.Response.WriteAsync(json);

      _logger.LogWarning("Resource not found: {Path}", context.Request.Path);
    }
  }
}

// Extension method for cleaner startup configuration
public static class NotFoundMiddlewareExtensions
{
  public static IApplicationBuilder UseNotFoundHandler(this IApplicationBuilder builder)
  {
    return builder.UseMiddleware<NotFoundMiddleware>();
  }
}