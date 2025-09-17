// src/MyOpenTelemetryApi.Application/DTOs/PhoneNumberDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class PhoneNumberDto
{
    public Guid Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsPrimary { get; set; }
}

public class CreatePhoneNumberDto
{
    public string Number { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public bool IsPrimary { get; set; }
}
