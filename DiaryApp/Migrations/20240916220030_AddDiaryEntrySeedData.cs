using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDiaryEntrySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "contemplating life with my Deus Imperator PHG", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "contemplating life" },
                    { 2, "contemplating the moon with my Deus Imperator PHG", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "contemplating the moon" },
                    { 3, "contemplating the sun with my Deus Imperator PHG", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "contemplating the sun" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
