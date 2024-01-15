using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedrealizeddatefortest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "RealizedDate" },
                values: new object[] { "Dette er en realiseret kommentar", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "RealizedDate" },
                values: new object[] { null, null });
        }
    }
}
