using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class domainmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StandardSubGoals_Phase_PhaseId",
                table: "StandardSubGoals");

            migrationBuilder.DropTable(
                name: "PhaseSubProject");

            migrationBuilder.DropTable(
                name: "Phase");

            migrationBuilder.AddColumn<int>(
                name: "StandardPhaseId",
                table: "SubProjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StandardPhase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardPhase", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StandardPhase",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Denne fase...", "Testning" },
                    { 2, "Denne fase...", "Opstartsfase" }
                });

            migrationBuilder.UpdateData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "StandardPhaseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "StandardPhaseId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_SubProjects_StandardPhaseId",
                table: "SubProjects",
                column: "StandardPhaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StandardSubGoals_StandardPhase_PhaseId",
                table: "StandardSubGoals",
                column: "PhaseId",
                principalTable: "StandardPhase",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubProjects_StandardPhase_StandardPhaseId",
                table: "SubProjects",
                column: "StandardPhaseId",
                principalTable: "StandardPhase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StandardSubGoals_StandardPhase_PhaseId",
                table: "StandardSubGoals");

            migrationBuilder.DropForeignKey(
                name: "FK_SubProjects_StandardPhase_StandardPhaseId",
                table: "SubProjects");

            migrationBuilder.DropTable(
                name: "StandardPhase");

            migrationBuilder.DropIndex(
                name: "IX_SubProjects_StandardPhaseId",
                table: "SubProjects");

            migrationBuilder.DropColumn(
                name: "StandardPhaseId",
                table: "SubProjects");

            migrationBuilder.CreateTable(
                name: "Phase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phase", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Phase",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Denne fase...", "Testning" },
                    { 2, "Denne fase...", "Opstartsfase" }
                });

            migrationBuilder.InsertData(
                table: "PhaseSubProject",
                columns: new[] { "PhasesId", "SubProjectsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhaseSubProject_SubProjectsId",
                table: "PhaseSubProject",
                column: "SubProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StandardSubGoals_Phase_PhaseId",
                table: "StandardSubGoals",
                column: "PhaseId",
                principalTable: "Phase",
                principalColumn: "Id");
        }
    }
}
