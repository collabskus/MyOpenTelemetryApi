// src/MyOpenTelemetryApi.Application/Services/TagService.cs
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;

namespace MyOpenTelemetryApi.Application.Services;

public class TagService(IUnitOfWork unitOfWork) : ITagService
{
    public async Task<TagDto?> GetByIdAsync(Guid id)
    {
        Tag? tag = await unitOfWork.Tags.GetByIdAsync(id);
        return tag == null ? null : MapToDto(tag);
    }

    public async Task<List<TagDto>> GetAllAsync()
    {
        IEnumerable<Tag> tags = await unitOfWork.Tags.GetAllAsync();
        return [.. tags.Select(MapToDto)];
    }

    public async Task<TagDto> CreateAsync(CreateTagDto dto)
    {
        // Check if tag with same name already exists
        Tag? existingTag = await unitOfWork.Tags.GetByNameAsync(dto.Name);
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

        await unitOfWork.Tags.AddAsync(tag);
        await unitOfWork.SaveChangesAsync();

        return MapToDto(tag);
    }

    public async Task<TagDto?> UpdateAsync(Guid id, CreateTagDto dto)
    {
        Tag? tag = await unitOfWork.Tags.GetByIdAsync(id);
        if (tag == null) return null;

        // Check if another tag with the same name exists
        Tag? existingTag = await unitOfWork.Tags.GetByNameAsync(dto.Name);
        if (existingTag != null && existingTag.Id != id)
        {
            throw new InvalidOperationException($"Tag with name '{dto.Name}' already exists.");
        }

        tag.Name = dto.Name;
        tag.ColorHex = dto.ColorHex;

        await unitOfWork.Tags.UpdateAsync(tag);
        await unitOfWork.SaveChangesAsync();

        return MapToDto(tag);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        Tag? tag = await unitOfWork.Tags.GetByIdAsync(id);
        if (tag == null) return false;

        await unitOfWork.Tags.DeleteAsync(tag);
        await unitOfWork.SaveChangesAsync();
        return true;
    }

    private TagDto MapToDto(Tag tag)
    {
        return new TagDto
        {
            Id = tag.Id,
            Name = tag.Name,
            ColorHex = tag.ColorHex
        };
    }
}
