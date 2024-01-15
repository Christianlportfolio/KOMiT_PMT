using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedMoreSeedData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name" },
                values: new object[,]
                {
                    { 8, "kurt@komit.dk", "Udvikler", "Kurt Jakobsen" },
                    { 9, "kevin@komit.dk", "Udvikler", "Kevin Poulsen" },
                    { 10, "signe@komit.dk", "Udvikler", "Signe Sørensen" },
                    { 11, "julie@komit.dk", "Udvikler", "Julie M. Frederiksen" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 15, "Jeg føler mig stærk i...", 8, "7 år", "C#" },
                    { 16, "Jeg føler mig stærk i...", 8, "2 år", "Blazor" },
                    { 17, "Jeg føler mig stærk i...", 9, "2 år", "HTML" },
                    { 18, "Jeg føler mig stærk i...", 9, "2 år", "CSS" },
                    { 19, "Jeg føler mig stærk i...", 10, "5 år", "JavaScript" },
                    { 20, "Jeg føler mig stærk i...", 11, "8 år", "Python" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
