using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MinorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competence_Employees_EmployeeId",
                table: "Competence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competence",
                table: "Competence");

            migrationBuilder.RenameTable(
                name: "Competence",
                newName: "Competences");

            migrationBuilder.RenameIndex(
                name: "IX_Competence_EmployeeId",
                table: "Competences",
                newName: "IX_Competences_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competences",
                table: "Competences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Competences_Employees_EmployeeId",
                table: "Competences",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competences_Employees_EmployeeId",
                table: "Competences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competences",
                table: "Competences");

            migrationBuilder.RenameTable(
                name: "Competences",
                newName: "Competence");

            migrationBuilder.RenameIndex(
                name: "IX_Competences_EmployeeId",
                table: "Competence",
                newName: "IX_Competence_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competence",
                table: "Competence",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Competence_Employees_EmployeeId",
                table: "Competence",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
