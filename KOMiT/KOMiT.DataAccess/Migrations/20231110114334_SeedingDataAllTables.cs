using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SubProjectId",
                table: "Phase");

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[,]
                {
                    { 1, "Jeg føler mig stærk i...", null, "5 år", "SQL" },
                    { 2, "Jeg føler mig stærk i...", null, "4 år", "C#" },
                    { 3, "Jeg føler mig stærk i...", null, "6 år", "Blazor" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "JobPosition", "Name", "ProjectMemberId" },
                values: new object[,]
                {
                    { 1, "pia@komit.dk", "Udvikler", "Pia Olsen", null },
                    { 2, "per@komit.dk", "Konsulent", "Per Hansen", null }
                });

            migrationBuilder.InsertData(
                table: "StandardSubGoals",
                columns: new[] { "Id", "Description", "Name", "PhaseId" },
                values: new object[,]
                {
                    { 1, "Dette delmål...", "E2E test", null },
                    { 2, "Dette delmål...", "Unit Testing", null },
                    { 3, "Dette delmål...", "Integration", null }
                });

            migrationBuilder.InsertData(
                table: "StandardTasks",
                columns: new[] { "Id", "Description", "StandardSubGoalId", "Title" },
                values: new object[,]
                {
                    { 1, "Denne opgave...", null, "Implementer test fixture for E2E" },
                    { 2, "Denne opgave...", null, "Unit Testing" },
                    { 3, "Denne opgave...", null, "Tilføj API til projekt" }
                });

            migrationBuilder.InsertData(
                table: "SubProjects",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "Status" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { 4, null, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "SubProjectId",
                table: "Phase",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "SubProjects",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "Status" },
                values: new object[] { 1, null, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 });
        }
    }
}
