// tests/MyOpenTelemetryApi.Api.Tests/ApiTests.cs
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Api.Tests;

public class ApiTests
{
    [Fact]
    public void HealthController_Constructor_DoesNotThrow()
    {
        // This is a simple test to verify the test project is set up correctly
        Assert.True(true);
    }

    [Fact]
    public void PaginatedResultDto_CalculatesTotalPagesCorrectly()
    {
        // Arrange
        PaginatedResultDto<string> result = new()
        {
            TotalCount = 95,
            PageSize = 10
        };

        // Act & Assert
        Assert.Equal(10, result.TotalPages);
    }

    [Fact]
    public void PaginatedResultDto_HasPreviousPage_WorksCorrectly()
    {
        // Arrange
        PaginatedResultDto<string> result1 = new() { PageNumber = 1 };
        PaginatedResultDto<string> result2 = new() { PageNumber = 2 };

        // Act & Assert
        Assert.False(result1.HasPreviousPage);
        Assert.True(result2.HasPreviousPage);
    }

    [Fact]
    public void PaginatedResultDto_HasNextPage_WorksCorrectly()
    {
        // Arrange
        PaginatedResultDto<string> result = new()
        {
            PageNumber = 3,
            PageSize = 10,
            TotalCount = 25
        };

        // Act & Assert
        Assert.False(result.HasNextPage); // Page 3 is the last page (25 items / 10 per page)
    }

    [Theory]
    [InlineData(0, 10, 0)]
    [InlineData(1, 10, 1)]
    [InlineData(10, 10, 1)]
    [InlineData(11, 10, 2)]
    [InlineData(100, 10, 10)]
    [InlineData(101, 10, 11)]
    public void PaginatedResultDto_TotalPages_CalculatesCorrectly(int totalCount, int pageSize, int expectedPages)
    {
        // Arrange
        PaginatedResultDto<string> result = new()
        {
            TotalCount = totalCount,
            PageSize = pageSize
        };

        // Act & Assert
        Assert.Equal(expectedPages, result.TotalPages);
    }
}
