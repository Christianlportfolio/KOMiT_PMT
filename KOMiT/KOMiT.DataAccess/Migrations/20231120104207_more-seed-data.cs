using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class moreseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CurrentSubGoals",
                columns: new[] { "Id", "Comment", "CurrentPhaseId", "Description", "EstimatedEndDate", "Name", "RealizedDate", "Status" },
                values: new object[] { 2, null, 1, "Dette er en testintegration", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Integration", null, 0 });

            migrationBuilder.InsertData(
                table: "CurrentSubGoalProjectMember",
                columns: new[] { "CurrentSubGoalsId", "ProjectMembersId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CurrentTasks",
                columns: new[] { "Id", "Comment", "CurrentSubGoalId", "Description", "EstimatedNumberOfDays", "RealizedDate", "Status", "Title" },
                values: new object[] { 2, null, 2, "Skriv og udfør enhedstest for integrationen", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Udfør enhedstest" });

            migrationBuilder.InsertData(
                table: "CurrentTaskProjectMember",
                columns: new[] { "CurrentTasksId", "ProjectMembersId" },
                values: new object[] { 2, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrentSubGoalProjectMember",
                keyColumns: new[] { "CurrentSubGoalsId", "ProjectMembersId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CurrentTaskProjectMember",
                keyColumns: new[] { "CurrentTasksId", "ProjectMembersId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CurrentTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CurrentSubGoals",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
