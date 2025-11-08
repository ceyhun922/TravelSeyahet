using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 42, 31, 805, DateTimeKind.Local).AddTicks(1280));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 8, 17, 41, 0, 247, DateTimeKind.Local).AddTicks(40));
        }
    }
}
