using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectType = table.Column<int>(type: "int", nullable: false),
                    EstimatedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealizedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardSubGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardSubGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StandardSubGoals_Phase_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "Phase",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectMemberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_ProjectMembers_ProjectMemberId",
                        column: x => x.ProjectMemberId,
                        principalTable: "ProjectMembers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EstimatedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealizedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StandardTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardSubGoalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StandardTasks_StandardSubGoals_StandardSubGoalId",
                        column: x => x.StandardSubGoalId,
                        principalTable: "StandardSubGoals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Competence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competence_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CurrentSubGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EstimatedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealizedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentSubGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentSubGoals_SubProjects_SubProjectId",
                        column: x => x.SubProjectId,
                        principalTable: "SubProjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhaseSubProject",
                columns: table => new
                {
                    PhasesId = table.Column<int>(type: "int", nullable: false),
                    SubProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhaseSubProject", x => new { x.PhasesId, x.SubProjectsId });
                    table.ForeignKey(
                        name: "FK_PhaseSubProject_Phase_PhasesId",
                        column: x => x.PhasesId,
                        principalTable: "Phase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhaseSubProject_SubProjects_SubProjectsId",
                        column: x => x.SubProjectsId,
                        principalTable: "SubProjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "CurrentTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentTaskStatus = table.Column<int>(type: "int", nullable: false),
                    EstimatedNumberOfDays = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealizedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentSubGoalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentTasks_CurrentSubGoals_CurrentSubGoalId",
                        column: x => x.CurrentSubGoalId,
                        principalTable: "CurrentSubGoals",
                        principalColumn: "Id");
                });

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
                name: "IX_Competence_EmployeeId",
                table: "Competence",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentSubGoalProjectMember_ProjectMembersId",
                table: "CurrentSubGoalProjectMember",
                column: "ProjectMembersId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentSubGoals_SubProjectId",
                table: "CurrentSubGoals",
                column: "SubProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTaskProjectMember_ProjectMembersId",
                table: "CurrentTaskProjectMember",
                column: "ProjectMembersId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTasks_CurrentSubGoalId",
                table: "CurrentTasks",
                column: "CurrentSubGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectMemberId",
                table: "Employees",
                column: "ProjectMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhaseSubProject_SubProjectsId",
                table: "PhaseSubProject",
                column: "SubProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_StandardSubGoals_PhaseId",
                table: "StandardSubGoals",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_StandardTasks_StandardSubGoalId",
                table: "StandardTasks",
                column: "StandardSubGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_SubProjects_ProjectId",
                table: "SubProjects",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competence");

            migrationBuilder.DropTable(
                name: "CurrentSubGoalProjectMember");

            migrationBuilder.DropTable(
                name: "CurrentTaskProjectMember");

            migrationBuilder.DropTable(
                name: "PhaseSubProject");

            migrationBuilder.DropTable(
                name: "StandardTasks");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "CurrentTasks");

            migrationBuilder.DropTable(
                name: "StandardSubGoals");

            migrationBuilder.DropTable(
                name: "ProjectMembers");

            migrationBuilder.DropTable(
                name: "CurrentSubGoals");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.DropTable(
                name: "SubProjects");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
