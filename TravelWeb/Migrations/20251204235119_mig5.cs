using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DestinationStatus",
                table: "Destinations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 11,
                column: "DestinationStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 13, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20,
                column: "TourClock",
                value: new DateTime(2025, 12, 5, 18, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationStatus",
                table: "Destinations");

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 13, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20,
                column: "TourClock",
                value: new DateTime(2025, 12, 2, 18, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
