using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateddependencybetweencurrenphaseandmembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentSubGoalProjectMember");

            migrationBuilder.DeleteData(
                table: "CurrentTaskProjectMember",
                keyColumns: new[] { "CurrentTasksId", "ProjectMembersId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.CreateTable(
                name: "CurrentPhaseProjectMember",
                columns: table => new
                {
                    CurrentPhasesId = table.Column<int>(type: "int", nullable: false),
                    ProjectMembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentPhaseProjectMember", x => new { x.CurrentPhasesId, x.ProjectMembersId });
                    table.ForeignKey(
                        name: "FK_CurrentPhaseProjectMember_CurrentPhases_CurrentPhasesId",
                        column: x => x.CurrentPhasesId,
                        principalTable: "CurrentPhases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentPhaseProjectMember_ProjectMembers_ProjectMembersId",
                        column: x => x.ProjectMembersId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Competence",
                columns: new[] { "Id", "Description", "EmployeeId", "Experience", "Title" },
                values: new object[] { 4, "Jeg føler mig stærk i...", 1, "4 år", "Testning" });

            migrationBuilder.InsertData(
                table: "CurrentPhaseProjectMember",
                columns: new[] { "CurrentPhasesId", "ProjectMembersId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProjectMembers",
                columns: new[] { "Id", "ProjectMemberStatus", "ProjectRole" },
                values: new object[] { 2, 0, "Projektleder" });

            migrationBuilder.InsertData(
                table: "CurrentPhaseProjectMember",
                columns: new[] { "CurrentPhasesId", "ProjectMembersId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CurrentTaskProjectMember",
                columns: new[] { "CurrentTasksId", "ProjectMembersId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "EmployeeProjectMember",
                columns: new[] { "EmployeesId", "ProjectMembersId" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentPhaseProjectMember_ProjectMembersId",
                table: "CurrentPhaseProjectMember",
                column: "ProjectMembersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentPhaseProjectMember");

            migrationBuilder.DeleteData(
                table: "Competence",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CurrentTaskProjectMember",
                keyColumns: new[] { "CurrentTasksId", "ProjectMembersId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProjectMember",
                keyColumns: new[] { "EmployeesId", "ProjectMembersId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "CurrentSubGoalProjectMember",
                columns: table => new
                {
                    CurrentSubGoalsId = table.Column<int>(type: "int", nullable: false),
                    ProjectMembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentSubGoalProjectMember", x => new { x.CurrentSubGoalsId, x.ProjectMembersId });
                    table.ForeignKey(
                        name: "FK_CurrentSubGoalProjectMember_CurrentSubGoals_CurrentSubGoalsId",
                        column: x => x.CurrentSubGoalsId,
                        principalTable: "CurrentSubGoals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentSubGoalProjectMember_ProjectMembers_ProjectMembersId",
                        column: x => x.ProjectMembersId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CurrentSubGoalProjectMember",
                columns: new[] { "CurrentSubGoalsId", "ProjectMembersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "CurrentTaskProjectMember",
                columns: new[] { "CurrentTasksId", "ProjectMembersId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentSubGoalProjectMember_ProjectMembersId",
                table: "CurrentSubGoalProjectMember",
                column: "ProjectMembersId");
        }
    }
}
