using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedMoreSeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name" },
                values: new object[,]
                {
                    { 6, "sofie@komit.dk", "Marketing Specialist", "Sofie Pedersen" },
                    { 7, "mikkel@komit.dk", "Systemadministrator", "Mikkel Andersen" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 11, "Jeg føler mig stærk i...", 6, "4 år", "Marketing" },
                    { 12, "Jeg føler mig stærk i...", 6, "4 år", "Strategier" },
                    { 13, "Jeg føler mig stærk i...", 7, "10 år", "Systemadministration" },
                    { 14, "Jeg føler mig stærk i...", 7, "10 år", "Scripting" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
