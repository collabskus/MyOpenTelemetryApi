// src/MyOpenTelemetryApi.Api/Controllers/TagsController.cs
using Microsoft.AspNetCore.Mvc;
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Application.Services;

namespace MyOpenTelemetryApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TagsController(ITagService tagService, ILogger<TagsController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<TagDto>>> GetTags(CancellationToken cancellationToken = default)
    {
        List<TagDto> tags = await tagService.GetAllAsync(cancellationToken);
        return Ok(tags);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TagDto>> GetTag(Guid id, CancellationToken cancellationToken = default)
    {
        TagDto? tag = await tagService.GetByIdAsync(id, cancellationToken);
        if (tag == null)
        {
            return NotFound();
        }
        return Ok(tag);
    }

    [HttpPost]
    public async Task<ActionResult<TagDto>> CreateTag(CreateTagDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            TagDto tag = await tagService.CreateAsync(dto, cancellationToken);
            return CreatedAtAction(nameof(GetTag), new { id = tag.Id }, tag);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error creating tag");
            return StatusCode(500, "An error occurred while creating the tag.");
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<TagDto>> UpdateTag(Guid id, CreateTagDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            TagDto? tag = await tagService.UpdateAsync(id, dto, cancellationToken);
            if (tag == null)
            {
                return NotFound();
            }
            return Ok(tag);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error updating tag {TagId}", id);
            return StatusCode(500, "An error occurred while updating the tag.");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTag(Guid id, CancellationToken cancellationToken = default)
    {
        bool deleted = await tagService.DeleteAsync(id, cancellationToken);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
