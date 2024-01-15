using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubProjectId",
                table: "Phase",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstimatedEndDate", "EstimatedStartDate" },
                values: new object[] { new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstimatedEndDate", "EstimatedStartDate", "Name", "ProjectType" },
                values: new object[] { new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ElevDataPro", 0 });

            migrationBuilder.InsertData(
                table: "SubProjects",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "Status" },
                values: new object[] { 1, null, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubProjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SubProjectId",
                table: "Phase");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstimatedEndDate", "EstimatedStartDate" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 10, 40, 21, 993, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstimatedEndDate", "EstimatedStartDate", "Name", "ProjectType" },
                values: new object[] { new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 10, 10, 40, 21, 993, DateTimeKind.Local).AddTicks(6348), "Skema og tid", 1 });
        }
    }
}
