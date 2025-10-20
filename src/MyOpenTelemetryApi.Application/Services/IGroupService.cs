// src/MyOpenTelemetryApi.Application/Services/IGroupService.cs
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Application.Services;

public interface IGroupService
{
    Task<GroupDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<GroupDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<GroupDto> CreateAsync(CreateGroupDto dto, CancellationToken cancellationToken = default);
    Task<GroupDto?> UpdateAsync(Guid id, UpdateGroupDto dto, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
