using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class moreseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Projektet 'Skema og tid' fokuserer på udviklingen af et avanceret planlægningsværktøj skræddersyet til skolemiljøer. Dette værktøj vil muliggøre nem tilføjelse og administration af skemaer, hvilket gør det lettere for skolepersonale at oprette og vedligeholde skemalægning for undervisning og aktiviteter. Med en prioritet på 'Høj' og planlagt start den 9. november 2023 og forventet afslutning den 9. december 2024, sigter projektet mod at levere en brugervenlig og effektiv løsning, der imødekommer skolernes behov for struktureret tidsstyring.");

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Comment", "Description", "EstimatedEndDate", "EstimatedStartDate", "Name", "Priority", "ProjectType", "RealizedDate", "Status" },
                values: new object[,]
                {
                    { 3, null, "Dette er et nyt projekt...", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ØkonomiskolePro", 2, 1, null, 0 },
                    { 4, null, "Dette er et nyt projekt...", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ElevTilmeldingPro", 1, 2, null, 0 },
                    { 5, null, "Dette er et nyt projekt...", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BibliotekMesteren", 2, 1, null, 0 },
                    { 6, null, "Dette er et nyt projekt...", new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KantineKlar", 1, 0, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "StandardPhases",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "Denne fase...", "Implementering" },
                    { 4, "Denne fase...", "Afrapportering" }
                });

            migrationBuilder.InsertData(
                table: "CurrentPhases",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "StandardPhaseId", "Status" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 1, 0 },
                    { 4, null, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 2, 0 },
                    { 5, null, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, 1, 0 },
                    { 6, null, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, 3, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StandardPhases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StandardPhases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Dette projekt...");
        }
    }
}
