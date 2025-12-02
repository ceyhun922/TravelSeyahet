using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Rezervations",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_DestinationId",
                table: "Rezervations",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_Destinations_DestinationId",
                table: "Rezervations",
                column: "DestinationId",
                principalTable: "Destinations",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_Destinations_DestinationId",
                table: "Rezervations");

            migrationBuilder.DropIndex(
                name: "IX_Rezervations_DestinationId",
                table: "Rezervations");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Rezervations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 13, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20,
                column: "TourClock",
                value: new DateTime(2025, 11, 17, 18, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
