// src/MyOpenTelemetryApi.Application/Services/GroupService.cs
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;

namespace MyOpenTelemetryApi.Application.Services;

public class GroupService(IUnitOfWork unitOfWork) : IGroupService
{
    public async Task<GroupDto?> GetByIdAsync(Guid id)
    {
        Group? group = await unitOfWork.Groups.GetByIdAsync(id);
        return group == null ? null : MapToDto(group);
    }

    public async Task<List<GroupDto>> GetAllAsync()
    {
        IEnumerable<Group> groups = await unitOfWork.Groups.GetAllAsync();
        List<GroupDto> groupDtos = [];

        foreach (Group group in groups)
        {
            groupDtos.Add(MapToDto(group));
        }

        return groupDtos;
    }

    public async Task<GroupDto> CreateAsync(CreateGroupDto dto)
    {
        Group group = new()
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow
        };

        await unitOfWork.Groups.AddAsync(group);
        await unitOfWork.SaveChangesAsync();

        return MapToDto(group);
    }

    public async Task<GroupDto?> UpdateAsync(Guid id, UpdateGroupDto dto)
    {
        Group? group = await unitOfWork.Groups.GetByIdAsync(id);
        if (group == null) return null;

        group.Name = dto.Name;
        group.Description = dto.Description;

        unitOfWork.Groups.Update(group);
        await unitOfWork.SaveChangesAsync();

        return MapToDto(group);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        Group? group = await unitOfWork.Groups.GetByIdAsync(id);
        if (group == null) return false;

        unitOfWork.Groups.Delete(group);
        await unitOfWork.SaveChangesAsync();
        return true;
    }

    private static GroupDto MapToDto(Group group)
    {
        return new GroupDto
        {
            Id = group.Id,
            Name = group.Name,
            Description = group.Description,
            CreatedAt = group.CreatedAt,
            ContactCount = group.ContactGroups?.Count ?? 0
        };
    }
}
