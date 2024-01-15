using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KOMiT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addmoreseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Priority",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Comment", "Description", "EstimatedEndDate", "EstimatedStartDate", "Name", "Priority", "ProjectType", "RealizedDate", "Status" },
                values: new object[,]
                {
                    { 7, null, "Dette projekt fokuserer på udviklingen af en avanceret læringsplatform, der integrerer diverse undervisningsressourcer og muliggør effektiv kommunikation mellem elever og lærere. Med en prioritet på 'Høj' og planlagt start den 1. februar 2024 og forventet afslutning den 1. august 2025, sigter projektet mod at forbedre undervisningsoplevelsen og styrke samarbejdet i skolemiljøet.", new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LæringsplatformPro", 0, 1, null, 0 },
                    { 8, null, "Dette projekt fokuserer på at styrke IT-sikkerheden i skolemiljøet ved implementering af avancerede sikkerhedsforanstaltninger og trusselsbeskyttelse. Med en prioritet på 'Mellem' og planlagt start den 1. april 2024 og forventet afslutning den 1. juni 2024, sigter projektet mod at skabe en tryggere digital læringsmiljø.", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT-SikkerhedPro", 1, 1, null, 0 },
                    { 9, null, "Dette projekt fokuserer på at udvikle en omfattende eksamensadministrationssystem til skoler. Målet er at gøre processen med at planlægge og administrere eksamener mere effektiv og strømlinet. Med en prioritet på 'Mellem' og planlagt start den 1. september 2024 og forventet afslutning den 1. januar 2025, sigter projektet mod at lette byrden for skoleledere og eksamensansvarlige.", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EksamensadministrationPro", 1, 1, null, 0 },
                    { 10, null, "Dette projekt fokuserer på at integrere avancerede digitale værktøjer i klasseværelset for at forbedre undervisningsmetoderne. Med en prioritet på 'Høj' og planlagt start den 1. januar 2025 og forventet afslutning den 1. juni 2025, sigter projektet mod at skabe en innovativ læringsoplevelse for eleverne.", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digitalt Klasseværelse", 0, 1, null, 1 },
                    { 13, null, "Projektet 'ForældreportalOptimering' har til formål at optimere og forbedre skolens forældreportal. Med en prioritet på 'Mellem' og planlagt start den 1. september 2022 og forventet afslutning den 1. december 2022, sigter projektet mod at styrke kommunikationen mellem skole og forældre.", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ForældreportalOptimering", 1, 1, null, 2 },
                    { 14, null, "Projektet 'SkolebiblioteksIntegration' fokuserer på integration af et avanceret bibliotekssystem direkte i skolens digitale infrastruktur. Med en prioritet på 'Høj' og planlagt start den 1. maj 2022 og forventet afslutning den 1. november 2022, sigter projektet mod at gøre det lettere for elever og lærere at få adgang til læringsressourcer.", new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SkolebiblioteksIntegration", 0, 2, null, 2 },
                    { 15, null, "Projektet 'Digital Evaluering' sigter mod at implementere et digitalt evalueringssystem for lærere og elever. Med en prioritet på 'Mellem' og planlagt start den 1. oktober 2022 og forventet afslutning den 1. februar 2023, vil projektet gøre det lettere at indsamle og analysere feedback for at forbedre undervisningen.", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Digital Evaluering", 1, 1, null, 2 },
                    { 16, null, "Projektet 'KlasserumsstyringPro' fokuserer på udviklingen af avancerede værktøjer til effektiv styring af klasseværelser. Med en prioritet på 'Høj' og planlagt start den 1. august 2022 og forventet afslutning den 1. maj 2023, sigter projektet mod at optimere læringsmiljøet.", new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KlasserumsstyringPro", 0, 3, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "CurrentPhases",
                columns: new[] { "Id", "Comment", "EstimatedEndDate", "EstimatedStartDate", "ProjectId", "RealizedDate", "StandardPhaseId", "Status" },
                values: new object[,]
                {
                    { 7, null, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, 2, 0 },
                    { 8, null, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, 2, 0 },
                    { 9, null, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null, 3, 0 },
                    { 10, null, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null, 2, 0 },
                    { 13, null, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null, 1, 2 },
                    { 14, null, new DateTime(2022, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, 4, 2 },
                    { 15, null, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null, 4, 2 },
                    { 16, null, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, null, 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "CurrentPhases",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Priority",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 0);
        }
    }
}
