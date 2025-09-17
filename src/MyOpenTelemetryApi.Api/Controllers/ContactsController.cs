// src/MyOpenTelemetryApi.Api/Controllers/ContactsController.cs
using Microsoft.AspNetCore.Mvc;
using MyOpenTelemetryApi.Application.Services;
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactsController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet]
    public async Task<ActionResult<PaginatedResultDto<ContactSummaryDto>>> GetContacts(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 20,
        CancellationToken cancellationToken = default)
    {
        var contacts = await _contactService.GetPaginatedAsync(pageNumber, pageSize, cancellationToken);
        return Ok(contacts);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ContactDto>> GetContact(Guid id, CancellationToken cancellationToken = default)
    {
        var contact = await _contactService.GetWithDetailsAsync(id, cancellationToken);
        if (contact == null)
        {
            return NotFound();
        }
        return Ok(contact);
    }

    [HttpPost]
    public async Task<ActionResult<ContactDto>> CreateContact(
        CreateContactDto dto,
        CancellationToken cancellationToken = default)
    {
        var contact = await _contactService.CreateAsync(dto, cancellationToken);
        return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult<ContactDto>> UpdateContact(
        Guid id,
        UpdateContactDto dto,
        CancellationToken cancellationToken = default)
    {
        var contact = await _contactService.UpdateAsync(id, dto, cancellationToken);
        if (contact == null)
        {
            return NotFound();
        }
        return Ok(contact);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteContact(Guid id, CancellationToken cancellationToken = default)
    {
        var success = await _contactService.DeleteAsync(id, cancellationToken);
        if (!success)
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpGet("search")]
    public async Task<ActionResult<List<ContactSummaryDto>>> SearchContacts(
        [FromQuery] string query,
        CancellationToken cancellationToken = default)
    {
        var contacts = await _contactService.SearchAsync(query, cancellationToken);
        return Ok(contacts);
    }

    [HttpGet("group/{groupId:guid}")]
    public async Task<ActionResult<List<ContactSummaryDto>>> GetContactsByGroup(
        Guid groupId,
        CancellationToken cancellationToken = default)
    {
        var contacts = await _contactService.GetByGroupAsync(groupId, cancellationToken);
        return Ok(contacts);
    }

    [HttpGet("tag/{tagId:guid}")]
    public async Task<ActionResult<List<ContactSummaryDto>>> GetContactsByTag(
        Guid tagId,
        CancellationToken cancellationToken = default)
    {
        var contacts = await _contactService.GetByTagAsync(tagId, cancellationToken);
        return Ok(contacts);
    }
}