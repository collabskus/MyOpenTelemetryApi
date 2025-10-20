// src/MyOpenTelemetryApi.Application/Services/GroupService.cs
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;

namespace MyOpenTelemetryApi.Application.Services;

public class GroupService(IUnitOfWork unitOfWork) : IGroupService
{
    public async Task<GroupDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        Group? group = await unitOfWork.Groups.GetByIdAsync(id, cancellationToken);
        return group == null ? null : MapToDto(group);
    }

    public async Task<List<GroupDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IEnumerable<Group> groups = await unitOfWork.Groups.GetAllAsync(cancellationToken);
        List<GroupDto> groupDtos = [];

        foreach (Group group in groups)
        {
            groupDtos.Add(MapToDto(group));
        }

        return groupDtos;
    }

    public async Task<GroupDto> CreateAsync(CreateGroupDto dto, CancellationToken cancellationToken = default)
    {
        Group group = new()
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow
        };

        await unitOfWork.Groups.AddAsync(group, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return MapToDto(group);
    }

    public async Task<GroupDto?> UpdateAsync(Guid id, UpdateGroupDto dto, CancellationToken cancellationToken = default)
    {
        Group? group = await unitOfWork.Groups.GetByIdAsync(id, cancellationToken);
        if (group == null) return null;

        group.Name = dto.Name;
        group.Description = dto.Description;

        unitOfWork.Groups.Update(group);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return MapToDto(group);
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        Group? group = await unitOfWork.Groups.GetByIdAsync(id, cancellationToken);
        if (group == null) return false;

        unitOfWork.Groups.Delete(group);
        await unitOfWork.SaveChangesAsync(cancellationToken);
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
