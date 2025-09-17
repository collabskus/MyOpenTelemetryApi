// Api/Controllers/ContactsController.cs
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyOpenTelemetryApi.Application.DTOs;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ContactsController : ControllerBase
{
    private readonly IContactService _contactService;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetContact(
        Guid id,
        CancellationToken cancellationToken) // ✅ ASP.NET provides this automatically
    {
        var contact = await _contactService.GetContactByIdAsync(id, cancellationToken);
        return contact != null ? Ok(contact) : NotFound();
    }

    [HttpGet]
    public async Task<IActionResult> GetContacts(
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string? sort = null,
        [FromQuery] string? filter = null,
        CancellationToken cancellationToken) // ✅ Automatically injected
    {
        var result = await _contactService.GetPaginatedContactsAsync(
            pageNumber, pageSize, sort, filter, cancellationToken);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateContact(
        CreateContactDto dto,
        CancellationToken cancellationToken)
    {
        var contact = await _contactService.CreateContactAsync(dto, cancellationToken);
        return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
    }
}
