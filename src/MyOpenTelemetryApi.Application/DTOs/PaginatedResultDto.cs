// src/MyOpenTelemetryApi.Application/DTOs/PaginatedResultDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class PaginatedResultDto<T>
{
    public List<T> Items { get; set; } = [];
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
    public int TotalCount { get; set; }
    public bool HasPreviousPage { get; set; }
    public bool HasNextPage { get; set; }
}