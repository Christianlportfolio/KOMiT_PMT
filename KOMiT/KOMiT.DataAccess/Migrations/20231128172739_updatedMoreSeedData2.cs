using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedMoreSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name" },
                values: new object[] { 5, "kristian@komit.dk", "Projektleder", "Kristian Kristensen" });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 9, "Jeg føler mig stærk i...", 5, "9 år", "Ledelse" },
                    { 10, "Jeg føler mig stærk i...", 5, "9 år", "Drift" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
