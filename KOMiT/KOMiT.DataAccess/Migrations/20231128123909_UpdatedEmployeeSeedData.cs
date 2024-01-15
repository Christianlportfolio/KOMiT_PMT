using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedEmployeeSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Competence",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name" },
                values: new object[,]
                {
                    { 3, "lars@komit.dk", "UX Designer", "Lars Jensen" },
                    { 4, "camilla@komit.dk", "Projektleder", "Camilla Nielsen" },
                    { 5, "thomas@komit.dk", "Systemadministrator", "Thomas Madsen" },
                    { 6, "sofie@komit.dk", "Marketing Specialist", "Sofie Christensen" },
                    { 7, "frederik@komit.dk", "Data Scientist", "Frederik Andersen" }
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 5, "Jeg har erfaring med at skabe brugervenlige grænseflader...", 3, "6 år", "UI/UX Design" },
                    { 6, "Jeg har ledet flere vellykkede projekter...", 4, "8 år", "Project Management" },
                    { 7, "Jeg administrerer og vedligeholder virksomhedens netværksinfrastruktur...", 5, "7 år", "Network Administration" },
                    { 8, "Jeg har ekspertise inden for digital markedsføring...", 6, "5 år", "Digital Marketing" },
                    { 9, "Jeg arbejder med avancerede machine learning-algoritmer...", 7, "3 år", "Machine Learning" }
                });
        }
    }
}
