// src/MyOpenTelemetryApi.Application/Services/IGroupService.cs
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Application.Services;

public interface IGroupService
{
    Task<GroupDto?> GetByIdAsync(Guid id);
    Task<List<GroupDto>> GetAllAsync();
    Task<GroupDto> CreateAsync(CreateGroupDto dto);
    Task<GroupDto?> UpdateAsync(Guid id, UpdateGroupDto dto);
    Task<bool> DeleteAsync(Guid id);
}
