using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedMoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name" },
                values: new object[] { 3, "henrik@komit.dk", "Udvikler", "Henrik Sørense" });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 5, "Jeg føler mig stærk i...", 3, "4 år", "UX" },
                    { 6, "Jeg føler mig stærk i...", 3, "5 år", "HTML" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
