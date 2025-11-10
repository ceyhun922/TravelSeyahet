using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourLocaion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourClock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TourStatus = table.Column<bool>(type: "bit", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 11, 0, 2, 31, 684, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "DestinationId", "TourClock", "TourDetail", "TourLocaion", "TourStatus" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), "Tarixi şəhər turu", "İçərişəhər turu", true },
                    { 2, 1, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), "Bulvar gəzintisi", "Dənizkənarı Bulvar turu", true },
                    { 3, 1, new DateTime(2025, 11, 11, 20, 0, 0, 0, DateTimeKind.Local), "Panorama turları", "Flame Towers turu", true },
                    { 4, 2, new DateTime(2025, 11, 11, 10, 0, 0, 0, DateTimeKind.Local), "Dağ-xizək turu", "Tufandağ turu", true },
                    { 5, 2, new DateTime(2025, 11, 11, 15, 0, 0, 0, DateTimeKind.Local), "Göl ətrafında gəzinti", "Nohur gölü turu", true },
                    { 6, 2, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), "Tarixi tur", "Qəbələ Qədim şəhəri turu", true },
                    { 7, 3, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), "Mədəniyyət turu", "Şəki xan sarayı turu", true },
                    { 8, 3, new DateTime(2025, 11, 11, 13, 0, 0, 0, DateTimeKind.Local), "Tarixi kilsə turları", "Kiş kəndi turu", true },
                    { 9, 3, new DateTime(2025, 11, 11, 18, 0, 0, 0, DateTimeKind.Local), "Şirniyyat turu", "Şəki bazarı turu", true },
                    { 10, 4, new DateTime(2025, 11, 11, 8, 0, 0, 0, DateTimeKind.Local), "Meşə turu", "Qəçrəş turu", true },
                    { 11, 4, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), "Dağ kəndi turu", "Xınalıq turu", true },
                    { 12, 4, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), "Çay ətrafında gəzinti", "Qudyalçay turu", true },
                    { 13, 5, new DateTime(2025, 11, 11, 10, 0, 0, 0, DateTimeKind.Local), "Tarixi mədəni tur", "Cıdır düz turu", true },
                    { 14, 5, new DateTime(2025, 11, 11, 15, 0, 0, 0, DateTimeKind.Local), "Mədəni abidələr turu", "Yuxarı Gövhər Ağa məscidi turu", true },
                    { 15, 5, new DateTime(2025, 11, 11, 20, 0, 0, 0, DateTimeKind.Local), "Qala turu", "Şuşa qalası turu", true },
                    { 16, 6, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), "Ekoturizm", "Hirkan Milli Parkı turu", true },
                    { 17, 6, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), "Dəniz gəzintisi", "Mayak sahili turu", true },
                    { 18, 6, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), "Tarixi yerlər turu", "Lənkəran qalası turu", true },
                    { 19, 7, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), "Müalicəvi istirahət", "Naftalan sanatoriyası turu", true },
                    { 20, 7, new DateTime(2025, 11, 11, 13, 0, 0, 0, DateTimeKind.Local), "Şəhər gəzintisi", "Naftalan şəhər mərkəzi turu", true },
                    { 21, 7, new DateTime(2025, 11, 11, 18, 0, 0, 0, DateTimeKind.Local), "Açıq hava fəaliyyəti", "Naftalan parkı turu", true },
                    { 22, 8, new DateTime(2025, 11, 11, 8, 0, 0, 0, DateTimeKind.Local), "Əl sənətkarlıq turu", "Lahıc kəndi turu", true },
                    { 23, 8, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), "Təbiət gəzintisi", "İsmayıllı meşələri turu", true },
                    { 24, 8, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), "Mədəni tur", "Basqal kəndi turu", true },
                    { 25, 9, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), "Xizək turu", "Şahdağ turu", true },
                    { 26, 9, new DateTime(2025, 11, 11, 15, 0, 0, 0, DateTimeKind.Local), "Ailəvi istirahət", "Qusar şəhər parkı turu", true },
                    { 27, 9, new DateTime(2025, 11, 11, 20, 0, 0, 0, DateTimeKind.Local), "Dağ yürüşü", "Ləzə kəndi turu", true },
                    { 28, 10, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), "Tarixi tur", "Zaqatala qalası turu", true },
                    { 29, 10, new DateTime(2025, 11, 11, 13, 0, 0, 0, DateTimeKind.Local), "Mədəni kənd turu", "Yuxarı Çardaqlar turu", true },
                    { 30, 10, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), "Təbiət və mədəniyyət turu", "Qalal kəndi turu", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tours_DestinationId",
                table: "Tours",
                column: "DestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10,
                column: "DestinationTime",
                value: new DateTime(2025, 11, 9, 23, 6, 45, 126, DateTimeKind.Local).AddTicks(9090));
        }
    }
}
