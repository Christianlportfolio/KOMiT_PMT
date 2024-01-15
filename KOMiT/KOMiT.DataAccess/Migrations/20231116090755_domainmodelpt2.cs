using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class domainmodelpt2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentSubGoals_SubProjects_SubProjectId",
                table: "CurrentSubGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardSubGoals_StandardPhase_PhaseId",
                table: "StandardSubGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_SubProjects_Projects_ProjectId",
                table: "SubProjects");

            migrationBuilder.DropForeignKey(
                name: "FK_SubProjects_StandardPhase_StandardPhaseId",
                table: "SubProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubProjects",
                table: "SubProjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StandardPhase",
                table: "StandardPhase");

            migrationBuilder.RenameTable(
                name: "SubProjects",
                newName: "CurrentPhases");

            migrationBuilder.RenameTable(
                name: "StandardPhase",
                newName: "StandardPhases");

            migrationBuilder.RenameIndex(
                name: "IX_SubProjects_StandardPhaseId",
                table: "CurrentPhases",
                newName: "IX_CurrentPhases_StandardPhaseId");

            migrationBuilder.RenameIndex(
                name: "IX_SubProjects_ProjectId",
                table: "CurrentPhases",
                newName: "IX_CurrentPhases_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrentPhases",
                table: "CurrentPhases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StandardPhases",
                table: "StandardPhases",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentPhases_Projects_ProjectId",
                table: "CurrentPhases",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentPhases_StandardPhases_StandardPhaseId",
                table: "CurrentPhases",
                column: "StandardPhaseId",
                principalTable: "StandardPhases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentSubGoals_CurrentPhases_SubProjectId",
                table: "CurrentSubGoals",
                column: "SubProjectId",
                principalTable: "CurrentPhases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StandardSubGoals_StandardPhases_PhaseId",
                table: "StandardSubGoals",
                column: "PhaseId",
                principalTable: "StandardPhases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentPhases_Projects_ProjectId",
                table: "CurrentPhases");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrentPhases_StandardPhases_StandardPhaseId",
                table: "CurrentPhases");

            migrationBuilder.DropForeignKey(
                name: "FK_CurrentSubGoals_CurrentPhases_SubProjectId",
                table: "CurrentSubGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardSubGoals_StandardPhases_PhaseId",
                table: "StandardSubGoals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StandardPhases",
                table: "StandardPhases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrentPhases",
                table: "CurrentPhases");

            migrationBuilder.RenameTable(
                name: "StandardPhases",
                newName: "StandardPhase");

            migrationBuilder.RenameTable(
                name: "CurrentPhases",
                newName: "SubProjects");

            migrationBuilder.RenameIndex(
                name: "IX_CurrentPhases_StandardPhaseId",
                table: "SubProjects",
                newName: "IX_SubProjects_StandardPhaseId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrentPhases_ProjectId",
                table: "SubProjects",
                newName: "IX_SubProjects_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StandardPhase",
                table: "StandardPhase",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubProjects",
                table: "SubProjects",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentSubGoals_SubProjects_SubProjectId",
                table: "CurrentSubGoals",
                column: "SubProjectId",
                principalTable: "SubProjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StandardSubGoals_StandardPhase_PhaseId",
                table: "StandardSubGoals",
                column: "PhaseId",
                principalTable: "StandardPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubProjects_Projects_ProjectId",
                table: "SubProjects",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubProjects_StandardPhase_StandardPhaseId",
                table: "SubProjects",
                column: "StandardPhaseId",
                principalTable: "StandardPhase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
