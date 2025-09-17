// src/MyOpenTelemetryApi.Application/DTOs/ContactSummaryDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class ContactSummaryDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Company { get; set; }
    public string? PrimaryEmail { get; set; }
    public string? PrimaryPhone { get; set; }
}
