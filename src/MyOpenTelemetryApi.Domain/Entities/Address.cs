// src/MyOpenTelemetryApi.Domain/Entities/Address.cs
namespace MyOpenTelemetryApi.Domain.Entities;

public class Address
{
    public Guid Id { get; set; }
    public Guid ContactId { get; set; }
    public string? StreetLine1 { get; set; }
    public string? StreetLine2 { get; set; }
    public string? City { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public AddressType Type { get; set; }
    public bool IsPrimary { get; set; }

    // Navigation property
    public Contact Contact { get; set; } = null!;
}
