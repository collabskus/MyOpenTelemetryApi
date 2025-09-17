// src/MyOpenTelemetryApi.Application/DTOs/UpdateContactDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class UpdateContactDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string? Nickname { get; set; }
    public string? Company { get; set; }
    public string? JobTitle { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Notes { get; set; }
}
