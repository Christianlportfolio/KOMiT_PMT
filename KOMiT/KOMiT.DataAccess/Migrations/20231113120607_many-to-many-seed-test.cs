using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class manytomanyseedtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentTaskProjectMemberJoinTable");

            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "CurrentTaskProjectMember",
                columns: table => new
                {
                    CurrentTasksId = table.Column<int>(type: "int", nullable: false),
                    ProjectMembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTaskProjectMember", x => new { x.CurrentTasksId, x.ProjectMembersId });
                    table.ForeignKey(
                        name: "FK_CurrentTaskProjectMember_CurrentTasks_CurrentTasksId",
                        column: x => x.CurrentTasksId,
                        principalTable: "CurrentTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentTaskProjectMember_ProjectMembers_ProjectMembersId",
                        column: x => x.ProjectMembersId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Phase",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Denne fase...", "Opstartsfase" },
                    { 2, "Denne fase...", "Testning" }
                });

            migrationBuilder.InsertData(
                table: "SubProjects",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { 2, null, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "PhaseSubProject",
                columns: new[] { "PhasesId", "SubProjectsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTaskProjectMember_ProjectMembersId",
                table: "CurrentTaskProjectMember",
                column: "ProjectMembersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentTaskProjectMember");

            migrationBuilder.DeleteData(
                table: "PhaseSubProject",
                keyColumns: new[] { "PhasesId", "SubProjectsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PhaseSubProject",
                keyColumns: new[] { "PhasesId", "SubProjectsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phase",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phase",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "CurrentTaskProjectMemberJoinTable",
                columns: table => new
                {
                    CurrentTasksId = table.Column<int>(type: "int", nullable: false),
                    ProjectMembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTaskProjectMemberJoinTable", x => new { x.CurrentTasksId, x.ProjectMembersId });
                    table.ForeignKey(
                        name: "FK_CurrentTaskProjectMemberJoinTable_CurrentTasks_CurrentTasksId",
                        column: x => x.CurrentTasksId,
                        principalTable: "CurrentTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentTaskProjectMemberJoinTable_ProjectMembers_ProjectMembersId",
                        column: x => x.ProjectMembersId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SubProjects",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "Status" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { 4, null, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTaskProjectMemberJoinTable_ProjectMembersId",
                table: "CurrentTaskProjectMemberJoinTable",
                column: "ProjectMembersId");
        }
    }
}
