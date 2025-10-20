// src/MyOpenTelemetryApi.Api/Controllers/GroupsController.cs
using Microsoft.AspNetCore.Mvc;
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Application.Services;

namespace MyOpenTelemetryApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GroupsController(IGroupService groupService, ILogger<GroupsController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<GroupDto>>> GetGroups(CancellationToken cancellationToken = default)
    {
        List<GroupDto> groups = await groupService.GetAllAsync(cancellationToken);
        return Ok(groups);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GroupDto>> GetGroup(Guid id, CancellationToken cancellationToken = default)
    {
        GroupDto? group = await groupService.GetByIdAsync(id, cancellationToken);
        if (group == null)
        {
            return NotFound();
        }
        return Ok(group);
    }

    [HttpPost]
    public async Task<ActionResult<GroupDto>> CreateGroup(CreateGroupDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            GroupDto group = await groupService.CreateAsync(dto, cancellationToken);
            return CreatedAtAction(nameof(GetGroup), new { id = group.Id }, group);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error creating group");
            return StatusCode(500, "An error occurred while creating the group.");
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<GroupDto>> UpdateGroup(Guid id, UpdateGroupDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            GroupDto? group = await groupService.UpdateAsync(id, dto, cancellationToken);
            if (group == null)
            {
                return NotFound();
            }
            return Ok(group);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error updating group {GroupId}", id);
            return StatusCode(500, "An error occurred while updating the group.");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGroup(Guid id, CancellationToken cancellationToken = default)
    {
        bool deleted = await groupService.DeleteAsync(id, cancellationToken);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
