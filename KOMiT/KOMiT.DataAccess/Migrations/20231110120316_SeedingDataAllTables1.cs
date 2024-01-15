using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataAllTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentTaskProjectMember");

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
                table: "CurrentTasks",
                columns: new[] { "Id", "Comment", "CurrentSubGoalId", "Description", "EstimatedNumberOfDays", "RealizedDate", "Status", "Title" },
                values: new object[] { 1, null, null, "Klassen skal være public", new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Tilføj en klasse" });

            migrationBuilder.InsertData(
                table: "ProjectMembers",
                columns: new[] { "Id", "ProjectMemberStatus", "ProjectRole" },
                values: new object[] { 1, 0, "Udvikler" });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTaskProjectMemberJoinTable_ProjectMembersId",
                table: "CurrentTaskProjectMemberJoinTable",
                column: "ProjectMembersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentTaskProjectMemberJoinTable");

            migrationBuilder.DeleteData(
                table: "CurrentTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectMembers",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTaskProjectMember_ProjectMembersId",
                table: "CurrentTaskProjectMember",
                column: "ProjectMembersId");
        }
    }
}
