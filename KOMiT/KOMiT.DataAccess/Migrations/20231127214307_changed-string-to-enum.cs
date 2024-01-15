using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changedstringtoenum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProjectRole",
                table: "ProjectMembers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectRole",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProjectRole",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProjectRole",
                table: "ProjectMembers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProjectRole",
                value: "Udvikler");

            migrationBuilder.UpdateData(
                table: "ProjectMembers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProjectRole",
                value: "Projektleder");
        }
    }
}
