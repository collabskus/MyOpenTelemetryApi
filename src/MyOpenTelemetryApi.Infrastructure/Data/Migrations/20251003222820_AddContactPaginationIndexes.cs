// This is what to paste into the generated migration file
// After running: dotnet ef migrations add AddContactPaginationIndexes
// Find the file in: src/MyOpenTelemetryApi.Infrastructure/Data/Migrations/
// It will be named something like: 20251003182600_AddContactPaginationIndexes.cs

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyOpenTelemetryApi.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddContactPaginationIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Primary pagination index - for default sort by LastName, FirstName
            // This will dramatically improve query performance for the default sort order
            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LastName_FirstName_Id",
                table: "Contacts",
                columns: new[] { "LastName", "FirstName", "Id" });

            // Additional sort option indexes for other sort orders
            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Company_Id",
                table: "Contacts",
                columns: new[] { "Company", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FirstName_Id",
                table: "Contacts",
                columns: new[] { "FirstName", "Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_LastName_FirstName_Id",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_Company_Id",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FirstName_Id",
                table: "Contacts");
        }
    }
}
