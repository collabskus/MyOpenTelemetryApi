// src/MyOpenTelemetryApi.Application/Services/TagService.cs
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;

namespace MyOpenTelemetryApi.Application.Services;

public class TagService(IUnitOfWork unitOfWork) : ITagService
{
    public async Task<TagDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        Tag? tag = await unitOfWork.Tags.GetByIdAsync(id, cancellationToken);
        return tag == null ? null : MapToDto(tag);
    }

    public async Task<List<TagDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        IEnumerable<Tag> tags = await unitOfWork.Tags.GetAllAsync(cancellationToken);
        return [.. tags.Select(MapToDto)];
    }

    public async Task<TagDto> CreateAsync(CreateTagDto dto, CancellationToken cancellationToken = default)
    {
        // Check if tag with same name already exists
        Tag? existingTag = await unitOfWork.Tags.GetByNameAsync(dto.Name, cancellationToken);
        if (existingTag != null)
        {
            throw new InvalidOperationException($"Tag with name '{dto.Name}' already exists.");
        }

        Tag tag = new()
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            ColorHex = dto.ColorHex
        };

        await unitOfWork.Tags.AddAsync(tag, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return MapToDto(tag);
    }

    public async Task<TagDto?> UpdateAsync(Guid id, CreateTagDto dto, CancellationToken cancellationToken = default)
    {
        Tag? tag = await unitOfWork.Tags.GetByIdAsync(id, cancellationToken);
        if (tag == null) return null;

        // Check if another tag with the same name exists
        Tag? existingTag = await unitOfWork.Tags.GetByNameAsync(dto.Name, cancellationToken);
        if (existingTag != null && existingTag.Id != id)
        {
            throw new InvalidOperationException($"Another tag with name '{dto.Name}' already exists.");
        }

        tag.Name = dto.Name;
        tag.ColorHex = dto.ColorHex;

        unitOfWork.Tags.Update(tag);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return MapToDto(tag);
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        Tag? tag = await unitOfWork.Tags.GetByIdAsync(id, cancellationToken);
        if (tag == null) return false;

        unitOfWork.Tags.Delete(tag);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }

    private static TagDto MapToDto(Tag tag)
    {
        return new TagDto
        {
            Id = tag.Id,
            Name = tag.Name,
            ColorHex = tag.ColorHex  // Now works with nullable TagDto.ColorHex
        };
    }
}
