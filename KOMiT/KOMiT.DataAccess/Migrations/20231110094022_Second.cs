using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ProjectMembers",
                newName: "ProjectMemberStatus");

            migrationBuilder.RenameColumn(
                name: "CurrentTaskStatus",
                table: "CurrentTasks",
                newName: "Status");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstimatedStartDate", "Priority", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 10, 40, 21, 993, DateTimeKind.Local).AddTicks(6291), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstimatedStartDate", "Priority", "Status" },
                values: new object[] { new DateTime(2023, 11, 10, 10, 40, 21, 993, DateTimeKind.Local).AddTicks(6348), 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "ProjectMemberStatus",
                table: "ProjectMembers",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "CurrentTasks",
                newName: "CurrentTaskStatus");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "EstimatedStartDate",
                value: new DateTime(2023, 11, 9, 14, 51, 52, 350, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "EstimatedStartDate",
                value: new DateTime(2023, 11, 9, 14, 51, 52, 350, DateTimeKind.Local).AddTicks(6964));
        }
    }
}
