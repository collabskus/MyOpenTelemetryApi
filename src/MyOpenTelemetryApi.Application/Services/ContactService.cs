// src/MyOpenTelemetryApi.Application/Services/ContactService.cs
using System.Diagnostics;
using System.Diagnostics.Metrics;
using Microsoft.Extensions.Logging;
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;

namespace MyOpenTelemetryApi.Application.Services;

public class ContactService(
    IUnitOfWork unitOfWork,
    ILogger<ContactService> logger,
    ActivitySource activitySource,
    IMeterFactory meterFactory) : IContactService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly ILogger<ContactService> _logger = logger;
    private readonly ActivitySource _activitySource = activitySource;

    // OpenTelemetry Metrics
    private readonly Meter _meter = meterFactory.Create("MyOpenTelemetryApi.Contacts");
    private readonly Counter<long> _contactsCreated = meterFactory.Create("MyOpenTelemetryApi.Contacts")
        .CreateCounter<long>("contacts.created", "contacts", "Number of contacts created");
    private readonly Counter<long> _contactsDeleted = meterFactory.Create("MyOpenTelemetryApi.Contacts")
        .CreateCounter<long>("contacts.deleted", "contacts", "Number of contacts deleted");
    private readonly Counter<long> _contactSearches = meterFactory.Create("MyOpenTelemetryApi.Contacts")
        .CreateCounter<long>("contacts.searches", "searches", "Number of contact searches performed");
    private readonly Histogram<double> _searchDuration = meterFactory.Create("MyOpenTelemetryApi.Contacts")
        .CreateHistogram<double>("contacts.search.duration", "seconds", "Duration of contact search operations");

    public async Task<List<ContactDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetAllContacts", ActivityKind.Internal);

        _logger.LogInformation("Getting all contacts");

        IEnumerable<Contact> contacts = await _unitOfWork.Contacts.GetAllAsync();
        List<ContactDto> contactDtos = [];
        foreach (Contact contact in contacts)
        {
            contactDtos.Add(MapToDto(contact));
        }

        return contactDtos;
    }

    public async Task<ContactDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactById", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Getting contact by ID: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found: {ContactId}", id);
            return null;
        }

        return MapToDto(contact);
    }

    public async Task<ContactDto?> GetWithDetailsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactWithDetails", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Getting contact with details: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetContactWithDetailsAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found: {ContactId}", id);
            return null;
        }

        return MapToDto(contact);
    }

    public async Task<PaginatedResultDto<ContactSummaryDto>> GetPaginatedAsync(
        int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetPaginatedContacts", ActivityKind.Internal);
        activity?.SetTag("page.number", pageNumber);
        activity?.SetTag("page.size", pageSize);

        _logger.LogInformation("Getting paginated contacts: Page {PageNumber}, Size {PageSize}", pageNumber, pageSize);

        var query = _unitOfWork.Contacts.GetQueryable();
        var totalCount = await Task.Run(() => query.Count(), cancellationToken);

        var contacts = await Task.Run(() => query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList(), cancellationToken);

        return new PaginatedResultDto<ContactSummaryDto>
        {
            Items = contacts.Select(MapToSummaryDto).ToList(),
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }

    public async Task<List<ContactSummaryDto>> SearchAsync(string searchTerm, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("SearchContacts", ActivityKind.Internal);
        activity?.SetTag("search.term", searchTerm);

        _logger.LogInformation("Searching contacts with term: {SearchTerm}", searchTerm);

        // Record search metric and measure duration
        _contactSearches.Add(1, new KeyValuePair<string, object?>("search.term.length", searchTerm.Length));

        var stopwatch = Stopwatch.StartNew();
        var contacts = await _unitOfWork.Contacts.SearchContactsAsync(searchTerm);
        stopwatch.Stop();

        _searchDuration.Record(stopwatch.Elapsed.TotalSeconds,
            new KeyValuePair<string, object?>("result.count", contacts.Count()));

        activity?.SetTag("result.count", contacts.Count());

        return contacts.Select(MapToSummaryDto).ToList();
    }

    public async Task<List<ContactSummaryDto>> GetByGroupAsync(Guid groupId, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactsByGroup", ActivityKind.Internal);
        activity?.SetTag("group.id", groupId);

        _logger.LogInformation("Getting contacts by group: {GroupId}", groupId);

        var contacts = await _unitOfWork.Contacts.GetContactsByGroupAsync(groupId);
        return contacts.Select(MapToSummaryDto).ToList();
    }

    public async Task<List<ContactSummaryDto>> GetByTagAsync(Guid tagId, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactsByTag", ActivityKind.Internal);
        activity?.SetTag("tag.id", tagId);

        _logger.LogInformation("Getting contacts by tag: {TagId}", tagId);

        var contacts = await _unitOfWork.Contacts.GetContactsByTagAsync(tagId);
        return contacts.Select(MapToSummaryDto).ToList();
    }

    public async Task<ContactDto> CreateAsync(CreateContactDto dto, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("CreateContact", ActivityKind.Internal);

        _logger.LogInformation("Creating new contact: {FirstName} {LastName}", dto.FirstName, dto.LastName);

        Contact contact = new()
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            MiddleName = dto.MiddleName,
            Nickname = dto.Nickname,
            Company = dto.Company,
            JobTitle = dto.JobTitle,
            DateOfBirth = dto.DateOfBirth,
            Notes = dto.Notes,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        // Map email addresses
        if (dto.EmailAddresses != null)
        {
            contact.EmailAddresses = dto.EmailAddresses.Select(e => new EmailAddress
            {
                Id = Guid.NewGuid(),
                ContactId = contact.Id,
                Email = e.Email,
                Type = Enum.Parse<EmailType>(e.Type, ignoreCase: true),
                IsPrimary = e.IsPrimary
            }).ToList();
        }

        // Map phone numbers
        if (dto.PhoneNumbers != null)
        {
            contact.PhoneNumbers = dto.PhoneNumbers.Select(p => new PhoneNumber
            {
                Id = Guid.NewGuid(),
                ContactId = contact.Id,
                Number = p.Number,
                Type = Enum.Parse<PhoneType>(p.Type, ignoreCase: true),
                IsPrimary = p.IsPrimary
            }).ToList();
        }

        // Map addresses
        if (dto.Addresses != null)
        {
            contact.Addresses = dto.Addresses.Select(a => new Address
            {
                Id = Guid.NewGuid(),
                ContactId = contact.Id,
                StreetLine1 = a.StreetLine1,
                StreetLine2 = a.StreetLine2,
                City = a.City,
                StateProvince = a.StateProvince,
                PostalCode = a.PostalCode,
                Country = a.Country,
                Type = Enum.Parse<AddressType>(a.Type, ignoreCase: true),
                IsPrimary = a.IsPrimary
            }).ToList();
        }

        await _unitOfWork.Contacts.AddAsync(contact);

        // Handle groups
        if (dto.GroupIds != null && dto.GroupIds.Count != 0)
        {
            foreach (Guid groupId in dto.GroupIds)
            {
                Group? group = await _unitOfWork.Groups.GetByIdAsync(groupId);
                if (group != null)
                {
                    contact.ContactGroups ??= [];
                    contact.ContactGroups.Add(new ContactGroup
                    {
                        ContactId = contact.Id,
                        GroupId = groupId
                    });
                }
            }
        }

        // Handle tags
        if (dto.TagIds != null && dto.TagIds.Count != 0)
        {
            foreach (Guid tagId in dto.TagIds)
            {
                Tag? tag = await _unitOfWork.Tags.GetByIdAsync(tagId);
                if (tag != null)
                {
                    contact.Tags ??= [];
                    contact.Tags.Add(new ContactTag
                    {
                        ContactId = contact.Id,
                        TagId = tagId
                    });
                }
            }
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        // Record metric after successful creation
        _contactsCreated.Add(1,
            new KeyValuePair<string, object?>("company", dto.Company ?? "none"),
            new KeyValuePair<string, object?>("has.email", dto.EmailAddresses?.Count > 0),
            new KeyValuePair<string, object?>("has.phone", dto.PhoneNumbers?.Count > 0));

        activity?.SetTag("contact.id", contact.Id);
        _logger.LogInformation("Contact created successfully: {ContactId}", contact.Id);

        return MapToDto(contact);
    }

    public async Task<ContactDto?> UpdateAsync(Guid id, UpdateContactDto dto, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("UpdateContact", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Updating contact: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found for update: {ContactId}", id);
            return null;
        }

        contact.FirstName = dto.FirstName;
        contact.LastName = dto.LastName;
        contact.MiddleName = dto.MiddleName;
        contact.Nickname = dto.Nickname;
        contact.Company = dto.Company;
        contact.JobTitle = dto.JobTitle;
        contact.DateOfBirth = dto.DateOfBirth;
        contact.Notes = dto.Notes;
        contact.UpdatedAt = DateTime.UtcNow;

        _unitOfWork.Contacts.Update(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("Contact updated successfully: {ContactId}", id);

        return MapToDto(contact);
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("DeleteContact", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Deleting contact: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found for deletion: {ContactId}", id);
            return false;
        }

        _unitOfWork.Contacts.Delete(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        // Record deletion metric
        _contactsDeleted.Add(1,
            new KeyValuePair<string, object?>("company", contact.Company ?? "none"));

        _logger.LogInformation("Contact deleted successfully: {ContactId}", id);

        return true;
    }

    private static ContactDto MapToDto(Contact contact)
    {
        return new ContactDto
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            MiddleName = contact.MiddleName,
            Nickname = contact.Nickname,
            Company = contact.Company,
            JobTitle = contact.JobTitle,
            DateOfBirth = contact.DateOfBirth,
            Notes = contact.Notes,
            CreatedAt = contact.CreatedAt,
            UpdatedAt = contact.UpdatedAt,
            EmailAddresses = contact.EmailAddresses?.Select(e => new EmailAddressDto
            {
                Email = e.Email,
                Type = e.Type.ToString(),
                IsPrimary = e.IsPrimary
            }).ToList() ?? [],
            PhoneNumbers = contact.PhoneNumbers?.Select(p => new PhoneNumberDto
            {
                Number = p.Number,
                Type = p.Type.ToString(),
                IsPrimary = p.IsPrimary
            }).ToList() ?? [],
            Addresses = contact.Addresses?.Select(a => new AddressDto
            {
                StreetLine1 = a.StreetLine1,
                StreetLine2 = a.StreetLine2,
                City = a.City,
                StateProvince = a.StateProvince,
                PostalCode = a.PostalCode,
                Country = a.Country,
                Type = a.Type.ToString(),
                IsPrimary = a.IsPrimary
            }).ToList() ?? []
        };
    }

    private static ContactSummaryDto MapToSummaryDto(Contact contact)
    {
        return new ContactSummaryDto
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Company = contact.Company,
            PrimaryEmail = contact.EmailAddresses?.FirstOrDefault(e => e.IsPrimary)?.Email,
            PrimaryPhone = contact.PhoneNumbers?.FirstOrDefault(p => p.IsPrimary)?.Number
        };
    }
}
