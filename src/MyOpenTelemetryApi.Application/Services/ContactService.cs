// src/MyOpenTelemetryApi.Application/Services/ContactService.cs
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace MyOpenTelemetryApi.Application.Services;

public class ContactService : IContactService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<ContactService> _logger;
    private readonly ActivitySource _activitySource;
    private readonly Meter _meter;
    private readonly Counter<int> _contactsCreatedCounter;
    private readonly Counter<int> _contactsDeletedCounter;
    private readonly Counter<int> _searchCounter;
    private readonly Histogram<double> _searchDuration;

    public ContactService(IUnitOfWork unitOfWork, ILogger<ContactService> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _activitySource = new ActivitySource("MyOpenTelemetryApi.ContactService");
        _meter = new Meter("MyOpenTelemetryApi.ContactService", "1.0.0");

        // Initialize metrics
        _contactsCreatedCounter = _meter.CreateCounter<int>("contacts.created", description: "Number of contacts created");
        _contactsDeletedCounter = _meter.CreateCounter<int>("contacts.deleted", description: "Number of contacts deleted");
        _searchCounter = _meter.CreateCounter<int>("contacts.searches", description: "Number of contact searches performed");
        _searchDuration = _meter.CreateHistogram<double>("contacts.search.duration", unit: "ms", description: "Duration of contact searches");
    }

    public async Task<ContactDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactById", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Getting contact by ID: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found with ID: {ContactId}", id);
            return null;
        }

        return MapToDto(contact);
    }

    public async Task<ContactDto?> GetWithDetailsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactWithDetails", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Getting contact with details by ID: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetContactWithDetailsAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found with ID: {ContactId}", id);
            return null;
        }

        return MapToDto(contact);
    }

    public async Task<PaginatedResultDto<ContactSummaryDto>> GetPaginatedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetPaginatedContacts", ActivityKind.Internal);
        activity?.SetTag("page.number", pageNumber);
        activity?.SetTag("page.size", pageSize);

        _logger.LogInformation("Getting paginated contacts - Page: {PageNumber}, Size: {PageSize}", pageNumber, pageSize);

        IEnumerable<Contact> allContacts = await _unitOfWork.Contacts.GetAllAsync();
        List<Contact> contacts = allContacts.ToList();

        int totalCount = contacts.Count;

        List<Contact> pageContacts = contacts
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        List<ContactSummaryDto> contactSummaries = [];
        foreach (Contact contact in pageContacts)
        {
            contactSummaries.Add(MapToSummaryDto(contact));
        }

        return new PaginatedResultDto<ContactSummaryDto>
        {
            Items = contactSummaries,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalCount = totalCount
            // Removed: TotalPages, HasPreviousPage, HasNextPage - now calculated automatically
        };
    }

    public async Task<List<ContactSummaryDto>> SearchAsync(string searchTerm, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("SearchContacts", ActivityKind.Internal);
        activity?.SetTag("search.term", searchTerm);

        var stopwatch = Stopwatch.StartNew();

        _logger.LogInformation("Searching contacts with term: {SearchTerm}", searchTerm);

        _searchCounter.Add(1, new TagList([new("term.length", searchTerm.Length.ToString())]));

        IEnumerable<Contact> contacts = await _unitOfWork.Contacts.SearchContactsAsync(searchTerm);

        stopwatch.Stop();
        _searchDuration.Record(stopwatch.ElapsedMilliseconds);

        List<ContactSummaryDto> results = [];
        foreach (Contact contact in contacts)
        {
            results.Add(MapToSummaryDto(contact));
        }

        _logger.LogInformation("Search completed. Found {Count} contacts", results.Count);

        return results;
    }

    public async Task<ContactDto> CreateAsync(CreateContactDto dto, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("CreateContact", ActivityKind.Internal);
        activity?.SetTag("contact.firstName", dto.FirstName);
        activity?.SetTag("contact.lastName", dto.LastName);

        _logger.LogInformation("Creating contact: {FirstName} {LastName}", dto.FirstName, dto.LastName);

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
            EmailAddresses = [],
            PhoneNumbers = [],
            Addresses = [],
            ContactGroups = [],
            Tags = []
        };

        // Map Email Addresses
        foreach (CreateEmailAddressDto emailDto in dto.EmailAddresses)
        {
            if (Enum.TryParse<EmailType>(emailDto.Type, true, out EmailType emailType))
            {
                EmailAddress email = new()
                {
                    Id = Guid.NewGuid(),
                    ContactId = contact.Id,
                    Email = emailDto.Email,
                    Type = emailType,
                    IsPrimary = emailDto.IsPrimary
                };
                contact.EmailAddresses.Add(email);
            }
        }

        // Map Phone Numbers
        foreach (CreatePhoneNumberDto phoneDto in dto.PhoneNumbers)
        {
            if (Enum.TryParse<PhoneType>(phoneDto.Type, true, out PhoneType phoneType))
            {
                PhoneNumber phone = new()
                {
                    Id = Guid.NewGuid(),
                    ContactId = contact.Id,
                    Number = phoneDto.Number,
                    Type = phoneType,
                    IsPrimary = phoneDto.IsPrimary
                };
                contact.PhoneNumbers.Add(phone);
            }
        }

        // Map Addresses
        foreach (CreateAddressDto addressDto in dto.Addresses)
        {
            if (Enum.TryParse<AddressType>(addressDto.Type, true, out AddressType addressType))
            {
                Address address = new()
                {
                    Id = Guid.NewGuid(),
                    ContactId = contact.Id,
                    StreetLine1 = addressDto.StreetLine1,
                    StreetLine2 = addressDto.StreetLine2,
                    City = addressDto.City,
                    StateProvince = addressDto.StateProvince,
                    PostalCode = addressDto.PostalCode,
                    Country = addressDto.Country,
                    Type = addressType,
                    IsPrimary = addressDto.IsPrimary
                };
                contact.Addresses.Add(address);
            }
        }

        await _unitOfWork.Contacts.AddAsync(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _contactsCreatedCounter.Add(1);
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

        // Update basic properties
        contact.FirstName = dto.FirstName;
        contact.LastName = dto.LastName;
        contact.MiddleName = dto.MiddleName;
        contact.Nickname = dto.Nickname;
        contact.Company = dto.Company;
        contact.JobTitle = dto.JobTitle;
        contact.DateOfBirth = dto.DateOfBirth;
        contact.Notes = dto.Notes;

        await _unitOfWork.Contacts.UpdateAsync(contact);
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

        await _unitOfWork.Contacts.DeleteAsync(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _contactsDeletedCounter.Add(1);
        _logger.LogInformation("Contact deleted successfully: {ContactId}", id);

        return true;
    }

    public async Task<List<ContactSummaryDto>> GetByGroupAsync(Guid groupId, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactsByGroup", ActivityKind.Internal);
        activity?.SetTag("group.id", groupId);

        _logger.LogInformation("Getting contacts by group: {GroupId}", groupId);

        IEnumerable<Contact> contacts = await _unitOfWork.Contacts.GetContactsByGroupAsync(groupId);

        List<ContactSummaryDto> results = [];
        foreach (Contact contact in contacts)
        {
            results.Add(MapToSummaryDto(contact));
        }

        return results;
    }

    public async Task<List<ContactSummaryDto>> GetByTagAsync(Guid tagId, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactsByTag", ActivityKind.Internal);
        activity?.SetTag("tag.id", tagId);

        _logger.LogInformation("Getting contacts by tag: {TagId}", tagId);

        IEnumerable<Contact> contacts = await _unitOfWork.Contacts.GetContactsByTagAsync(tagId);

        List<ContactSummaryDto> results = [];
        foreach (Contact contact in contacts)
        {
            results.Add(MapToSummaryDto(contact));
        }

        return results;
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
            EmailAddresses = contact.EmailAddresses?.Select(e => new EmailAddressDto
            {
                Id = e.Id,
                Email = e.Email,
                Type = e.Type.ToString(),
                IsPrimary = e.IsPrimary
            }).ToList() ?? [],
            PhoneNumbers = contact.PhoneNumbers?.Select(p => new PhoneNumberDto
            {
                Id = p.Id,
                Number = p.Number,
                Type = p.Type.ToString(),
                IsPrimary = p.IsPrimary
            }).ToList() ?? [],
            Addresses = contact.Addresses?.Select(a => new AddressDto
            {
                Id = a.Id,
                StreetLine1 = a.StreetLine1,
                StreetLine2 = a.StreetLine2,
                City = a.City,
                StateProvince = a.StateProvince,
                PostalCode = a.PostalCode,
                Country = a.Country,
                Type = a.Type.ToString(),
                IsPrimary = a.IsPrimary
            }).ToList() ?? [],
            Groups = contact.ContactGroups?.Select(cg => new GroupDto
            {
                Id = cg.Group.Id,
                Name = cg.Group.Name,
                Description = cg.Group.Description,
                CreatedAt = cg.Group.CreatedAt
            }).ToList() ?? [],
            Tags = contact.Tags?.Select(ct => new TagDto
            {
                Id = ct.Tag.Id,
                Name = ct.Tag.Name,
                ColorHex = ct.Tag.ColorHex
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
