// src/MyOpenTelemetryApi.Api/Controllers/HealthController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOpenTelemetryApi.Infrastructure.Data;

namespace MyOpenTelemetryApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController(AppDbContext dbContext, ILogger<HealthController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetHealth()
    {
        var health = new
        {
            Status = "Healthy",
            Timestamp = DateTime.UtcNow,
            Service = "MyOpenTelemetryApi"
        };

        try
        {
            // Test database connectivity
            await dbContext.Database.CanConnectAsync();
            return Ok(health);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Health check failed");
            return StatusCode(503, new
            {
                Status = "Unhealthy",
                Timestamp = DateTime.UtcNow,
                Service = "MyOpenTelemetryApi",
                Error = "Database connection failed"
            });
        }
    }

    [HttpGet("ready")]
    public async Task<IActionResult> GetReadiness()
    {
        try
        {
            // Check if database is accessible and migrations are applied
            await dbContext.Database.CanConnectAsync();
            IEnumerable<string> pendingMigrations = await dbContext.Database.GetPendingMigrationsAsync();

            if (pendingMigrations.Any())
            {
                return StatusCode(503, new
                {
                    Status = "Not Ready",
                    Reason = "Database has pending migrations",
                    PendingMigrations = pendingMigrations
                });
            }

            return Ok(new
            {
                Status = "Ready",
                Timestamp = DateTime.UtcNow
            });
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Readiness check failed");
            return StatusCode(503, new
            {
                Status = "Not Ready",
                Reason = "Database check failed",
                Error = ex.Message
            });
        }
    }
}
