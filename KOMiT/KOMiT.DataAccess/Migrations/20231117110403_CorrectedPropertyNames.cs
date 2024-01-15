using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedPropertyNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentSubGoals_CurrentPhases_SubProjectId",
                table: "CurrentSubGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardSubGoals_StandardPhases_PhaseId",
                table: "StandardSubGoals");

            migrationBuilder.RenameColumn(
                name: "PhaseId",
                table: "StandardSubGoals",
                newName: "StandardPhaseId");

            migrationBuilder.RenameIndex(
                name: "IX_StandardSubGoals_PhaseId",
                table: "StandardSubGoals",
                newName: "IX_StandardSubGoals_StandardPhaseId");

            migrationBuilder.RenameColumn(
                name: "SubProjectId",
                table: "CurrentSubGoals",
                newName: "CurrentPhaseId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrentSubGoals_SubProjectId",
                table: "CurrentSubGoals",
                newName: "IX_CurrentSubGoals_CurrentPhaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentSubGoals_CurrentPhases_CurrentPhaseId",
                table: "CurrentSubGoals",
                column: "CurrentPhaseId",
                principalTable: "CurrentPhases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StandardSubGoals_StandardPhases_StandardPhaseId",
                table: "StandardSubGoals",
                column: "StandardPhaseId",
                principalTable: "StandardPhases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentSubGoals_CurrentPhases_CurrentPhaseId",
                table: "CurrentSubGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardSubGoals_StandardPhases_StandardPhaseId",
                table: "StandardSubGoals");

            migrationBuilder.RenameColumn(
                name: "StandardPhaseId",
                table: "StandardSubGoals",
                newName: "PhaseId");

            migrationBuilder.RenameIndex(
                name: "IX_StandardSubGoals_StandardPhaseId",
                table: "StandardSubGoals",
                newName: "IX_StandardSubGoals_PhaseId");

            migrationBuilder.RenameColumn(
                name: "CurrentPhaseId",
                table: "CurrentSubGoals",
                newName: "SubProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_CurrentSubGoals_CurrentPhaseId",
                table: "CurrentSubGoals",
                newName: "IX_CurrentSubGoals_SubProjectId");

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
    }
}
