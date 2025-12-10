using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mi3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutImage1",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "SubAboutTitleII",
                table: "SubAbouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "AboutStatus",
                table: "Abouts2",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "About2Image",
                table: "Abouts2",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "About2Description",
                table: "Abouts2",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AboutTitle2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "AboutStatus",
                table: "Abouts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AboutDetail",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AboutImage",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 13, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20,
                column: "TourClock",
                value: new DateTime(2025, 12, 10, 18, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubAboutTitleII",
                table: "SubAbouts");

            migrationBuilder.DropColumn(
                name: "AboutImage",
                table: "Abouts");

            migrationBuilder.AlterColumn<int>(
                name: "AboutStatus",
                table: "Abouts2",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "About2Image",
                table: "Abouts2",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "About2Description",
                table: "Abouts2",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AboutTitle2",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AboutStatus",
                table: "Abouts",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "AboutDetail",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AboutImage1",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20,
                column: "TourClock",
                value: new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
