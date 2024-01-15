using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixedsmallrelationsship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentSubGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubProjectId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "CurrentTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentSubGoalId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentSubGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "CurrentTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentSubGoalId",
                value: null);
        }
    }
}
