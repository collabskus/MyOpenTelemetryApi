// src/MyOpenTelemetryApi.Domain/Entities/PhoneNumber.cs
namespace MyOpenTelemetryApi.Domain.Entities;

public class PhoneNumber
{
    public Guid Id { get; set; }
    public Guid ContactId { get; set; }
    public string Number { get; set; } = string.Empty;
    public PhoneType Type { get; set; }
    public bool IsPrimary { get; set; }

    // Navigation property
    public Contact Contact { get; set; } = null!;
}
