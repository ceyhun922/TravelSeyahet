using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TourRaiting",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 15, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 14, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 11, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 10, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 8, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 12, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 9, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 13, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 16, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 17, 0, 0, 0, DateTimeKind.Local), 0 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20,
                columns: new[] { "TourClock", "TourRaiting" },
                values: new object[] { new DateTime(2025, 12, 6, 18, 0, 0, 0, DateTimeKind.Local), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TourRaiting",
                table: "Tours");

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
    }
}
