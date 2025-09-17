// src/MyOpenTelemetryApi.Application/DTOs/AddressDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class AddressDto
{
    public Guid Id { get; set; }
    public string? StreetLine1 { get; set; }
    public string? StreetLine2 { get; set; }
    public string? City { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string Type { get; set; } = string.Empty;
    public bool IsPrimary { get; set; }
}

public class CreateAddressDto
{
    public string? StreetLine1 { get; set; }
    public string? StreetLine2 { get; set; }
    public string? City { get; set; }
    public string? StateProvince { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string Type { get; set; } = string.Empty;
    public bool IsPrimary { get; set; }
}
