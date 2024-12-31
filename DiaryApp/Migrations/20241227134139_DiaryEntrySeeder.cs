using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class DiaryEntrySeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Ali", new DateTime(2024, 12, 27, 18, 41, 38, 997, DateTimeKind.Local).AddTicks(5309), "Went Hiking" },
                    { 2, "Went shopping with Ali", new DateTime(2024, 12, 27, 18, 41, 38, 997, DateTimeKind.Local).AddTicks(5627), "Went Shopping" },
                    { 3, "Went diving with Ali", new DateTime(2024, 12, 27, 18, 41, 38, 997, DateTimeKind.Local).AddTicks(5629), "Went Diving" }
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
