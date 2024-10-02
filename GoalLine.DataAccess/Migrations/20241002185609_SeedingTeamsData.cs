using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoalLine.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTeamsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9884), "Persepolis" },
                    { 2, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9888), "Esteghlal F.C." },
                    { 3, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9890), "Malavan" },
                    { 4, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9891), "Tractor" },
                    { 5, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9892), "Sepahan" },
                    { 6, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9893), "Foolad" },
                    { 7, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9894), "Gol Gohar" },
                    { 8, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9895), "Chadormalu" },
                    { 9, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9896), "Zob Ahan" },
                    { 10, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9897), "Esteghlal Khuzestan" },
                    { 11, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9898), "Aluminium Arak" },
                    { 12, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9899), "Mes Rafsanjan" },
                    { 13, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9900), "Kheybar" },
                    { 14, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9901), "Nassaji Mazandaran" },
                    { 15, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9902), "Shams Azar" },
                    { 16, new DateTime(2024, 10, 2, 18, 56, 9, 206, DateTimeKind.Utc).AddTicks(9903), "Havadar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
