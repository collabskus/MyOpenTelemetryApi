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
    public async Task<ActionResult<List<GroupDto>>> GetGroups()
    {
        List<GroupDto> groups = await groupService.GetAllAsync();
        return Ok(groups);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GroupDto>> GetGroup(Guid id)
    {
        GroupDto? group = await groupService.GetByIdAsync(id);
        if (group == null)
        {
            return NotFound();
        }
        return Ok(group);
    }

    [HttpPost]
    public async Task<ActionResult<GroupDto>> CreateGroup(CreateGroupDto dto)
    {
        try
        {
            GroupDto group = await groupService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetGroup), new { id = group.Id }, group);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error creating group");
            return StatusCode(500, "An error occurred while creating the group.");
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<GroupDto>> UpdateGroup(Guid id, UpdateGroupDto dto)
    {
        try
        {
            GroupDto? group = await groupService.UpdateAsync(id, dto);
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
    public async Task<IActionResult> DeleteGroup(Guid id)
    {
        bool deleted = await groupService.DeleteAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}
