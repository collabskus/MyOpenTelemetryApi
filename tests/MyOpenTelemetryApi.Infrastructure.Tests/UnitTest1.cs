// tests/MyOpenTelemetryApi.Infrastructure.Tests/InfrastructureTests.cs
using Microsoft.EntityFrameworkCore;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Tests;

public class InfrastructureTests
{
    [Fact]
    public void Contact_Entity_HasCorrectDefaults()
    {
        // Arrange & Act
        Contact contact = new();

        // Assert
        Assert.NotNull(contact.FirstName);
        Assert.NotNull(contact.LastName);
        Assert.NotNull(contact.EmailAddresses);
        Assert.NotNull(contact.PhoneNumbers);
        Assert.NotNull(contact.Addresses);
        Assert.NotNull(contact.ContactGroups);
        Assert.NotNull(contact.Tags);
        Assert.Empty(contact.EmailAddresses);
        Assert.Empty(contact.PhoneNumbers);
        Assert.Empty(contact.Addresses);
        Assert.Empty(contact.ContactGroups);
        Assert.Empty(contact.Tags);
    }

    [Fact]
    public void EmailAddress_Entity_CanBeCreated()
    {
        // Arrange & Act
        EmailAddress email = new()
        {
            Id = Guid.NewGuid(),
            ContactId = Guid.NewGuid(),
            Email = "test@example.com",
            Type = EmailType.Personal,
            IsPrimary = true
        };

        // Assert
        Assert.NotEqual(Guid.Empty, email.Id);
        Assert.NotEqual(Guid.Empty, email.ContactId);
        Assert.Equal("test@example.com", email.Email);
        Assert.Equal(EmailType.Personal, email.Type);
        Assert.True(email.IsPrimary);
    }

    [Fact]
    public void PhoneNumber_Entity_CanBeCreated()
    {
        // Arrange & Act
        PhoneNumber phone = new()
        {
            Id = Guid.NewGuid(),
            ContactId = Guid.NewGuid(),
            Number = "+1-555-123-4567",
            Type = PhoneType.Mobile,
            IsPrimary = true
        };

        // Assert
        Assert.NotEqual(Guid.Empty, phone.Id);
        Assert.NotEqual(Guid.Empty, phone.ContactId);
        Assert.Equal("+1-555-123-4567", phone.Number);
        Assert.Equal(PhoneType.Mobile, phone.Type);
        Assert.True(phone.IsPrimary);
    }

    [Fact]
    public void Address_Entity_CanBeCreated()
    {
        // Arrange & Act
        Address address = new()
        {
            Id = Guid.NewGuid(),
            ContactId = Guid.NewGuid(),
            StreetLine1 = "123 Main St",
            City = "Springfield",
            StateProvince = "IL",
            PostalCode = "62701",
            Country = "USA",
            Type = AddressType.Home,
            IsPrimary = true
        };

        // Assert
        Assert.NotEqual(Guid.Empty, address.Id);
        Assert.NotEqual(Guid.Empty, address.ContactId);
        Assert.Equal("123 Main St", address.StreetLine1);
        Assert.Equal("Springfield", address.City);
        Assert.Equal("IL", address.StateProvince);
        Assert.Equal("62701", address.PostalCode);
        Assert.Equal("USA", address.Country);
        Assert.Equal(AddressType.Home, address.Type);
        Assert.True(address.IsPrimary);
    }

    [Fact]
    public void Group_Entity_HasCorrectDefaults()
    {
        // Arrange & Act
        Group group = new();

        // Assert
        Assert.NotNull(group.Name);
        Assert.NotNull(group.ContactGroups);
        Assert.Empty(group.ContactGroups);
    }

    [Fact]
    public void Tag_Entity_HasCorrectDefaults()
    {
        // Arrange & Act
        Tag tag = new();

        // Assert
        Assert.NotNull(tag.Name);
        Assert.NotNull(tag.ContactTags);
        Assert.Empty(tag.ContactTags);
    }

    [Fact]
    public void ContactGroup_JoinEntity_CanBeCreated()
    {
        // Arrange
        Guid contactId = Guid.NewGuid();
        Guid groupId = Guid.NewGuid();
        DateTime addedAt = DateTime.UtcNow;

        // Act
        ContactGroup contactGroup = new()
        {
            ContactId = contactId,
            GroupId = groupId,
            AddedAt = addedAt
        };

        // Assert
        Assert.Equal(contactId, contactGroup.ContactId);
        Assert.Equal(groupId, contactGroup.GroupId);
        Assert.Equal(addedAt, contactGroup.AddedAt);
    }

    [Fact]
    public void ContactTag_JoinEntity_CanBeCreated()
    {
        // Arrange
        Guid contactId = Guid.NewGuid();
        Guid tagId = Guid.NewGuid();

        // Act
        ContactTag contactTag = new()
        {
            ContactId = contactId,
            TagId = tagId
        };

        // Assert
        Assert.Equal(contactId, contactTag.ContactId);
        Assert.Equal(tagId, contactTag.TagId);
    }

    [Theory]
    [InlineData("#FF0000", true)]
    [InlineData("#00FF00", true)]
    [InlineData("#0000FF", true)]
    [InlineData("#GGGGGG", false)]
    [InlineData("FF0000", false)]
    [InlineData("#FF00", false)]
    [InlineData(null, true)]
    [InlineData("", true)]
    public void Tag_ColorHex_ValidationPattern(string? colorHex, bool isValid)
    {
        // This tests the expected format for color hex values
        // Arrange & Act
        Tag tag = new() { Name = "Test", ColorHex = colorHex };

        // Assert
        if (isValid)
        {
            Assert.True(string.IsNullOrEmpty(tag.ColorHex) ||
                       (tag.ColorHex.Length == 7 && tag.ColorHex.StartsWith('#')));
        }
        else
        {
            Assert.False(tag.ColorHex?.Length == 7 &&
                        tag.ColorHex.StartsWith('#') &&
                        tag.ColorHex.Skip(1).All(c => "0123456789ABCDEFabcdef".Contains(c)));
        }
    }
}
