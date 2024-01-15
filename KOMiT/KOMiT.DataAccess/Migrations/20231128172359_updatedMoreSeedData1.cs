using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedMoreSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Henrik Sørensen");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name" },
                values: new object[] { 4, "janni@komit.dk", "Konsulent", "Janni Iversen" });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 7, "Jeg føler mig stærk i...", 4, "1 år", "Kunderådgivning" },
                    { 8, "Jeg føler mig stærk i...", 4, "3 år", "Salg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Henrik Sørense");
        }
    }
}
