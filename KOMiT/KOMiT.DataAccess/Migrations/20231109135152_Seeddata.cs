using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Comment", "Description", "EstimatedEndDate", "EstimatedStartDate", "Name", "ProjectType", "RealizedDate" },
                values: new object[,]
                {
                    { 1, null, "Dette projekt...", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 14, 51, 52, 350, DateTimeKind.Local).AddTicks(6921), "Skema og tid", 1, null },
                    { 2, null, "Dette projekt...", new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 14, 51, 52, 350, DateTimeKind.Local).AddTicks(6964), "Skema og tid", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
