using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_ProjectMembers_ProjectMemberId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProjectMemberId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "PhaseSubProject",
                keyColumns: new[] { "PhasesId", "SubProjectsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DropColumn(
                name: "ProjectMemberId",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "EmployeeProjectMember",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    ProjectMembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjectMember", x => new { x.EmployeesId, x.ProjectMembersId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjectMember_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjectMember_ProjectMembers_ProjectMembersId",
                        column: x => x.ProjectMembersId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmployeeId",
                value: 1);

            migrationBuilder.InsertData(
                table: "CurrentSubGoals",
                columns: new[] { "Id", "Comment", "Description", "EstimatedEndDate", "Name", "RealizedDate", "Status", "SubProjectId" },
                values: new object[] { 1, null, "Dette delmål...", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "E2E", null, 0, null });

            migrationBuilder.InsertData(
                table: "CurrentTaskProjectMember",
                columns: new[] { "CurrentTasksId", "ProjectMembersId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "CurrentTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Denne opgave...", "Implementere textfixture for E2E" });

            migrationBuilder.UpdateData(
                table: "Phase",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Testning");

            migrationBuilder.UpdateData(
                table: "Phase",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Opstartsfase");

            migrationBuilder.InsertData(
                table: "PhaseSubProject",
                columns: new[] { "PhasesId", "SubProjectsId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhaseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhaseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhaseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "StandardSubGoalId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "StandardSubGoalId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StandardSubGoalId", "Title" },
                values: new object[] { 3, "Implementere test fixture for integration" });

            migrationBuilder.InsertData(
                table: "StandardTasks",
                columns: new[] { "Id", "Description", "StandardSubGoalId", "Title" },
                values: new object[] { 4, "Denne opgave...", 3, "Test database" });

            migrationBuilder.InsertData(
                table: "CurrentSubGoalProjectMember",
                columns: new[] { "CurrentSubGoalsId", "ProjectMembersId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjectMember_ProjectMembersId",
                table: "EmployeeProjectMember",
                column: "ProjectMembersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjectMember");

            migrationBuilder.DeleteData(
                table: "CurrentSubGoalProjectMember",
                keyColumns: new[] { "CurrentSubGoalsId", "ProjectMembersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CurrentTaskProjectMember",
                keyColumns: new[] { "CurrentTasksId", "ProjectMembersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PhaseSubProject",
                keyColumns: new[] { "PhasesId", "SubProjectsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CurrentSubGoals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "ProjectMemberId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CurrentTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Klassen skal være public", "Tilføj en klasse" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectMemberId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProjectMemberId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Phase",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Opstartsfase");

            migrationBuilder.UpdateData(
                table: "Phase",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Testning");

            migrationBuilder.InsertData(
                table: "PhaseSubProject",
                columns: new[] { "PhasesId", "SubProjectsId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "StandardSubGoals",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "StandardSubGoalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "StandardSubGoalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "StandardTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StandardSubGoalId", "Title" },
                values: new object[] { null, "Tilføj API til projekt" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectMemberId",
                table: "Employees",
                column: "ProjectMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_ProjectMembers_ProjectMemberId",
                table: "Employees",
                column: "ProjectMemberId",
                principalTable: "ProjectMembers",
                principalColumn: "Id");
        }
    }
}
