using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class add_dtourdaynight1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_Tours_TourId",
                table: "Rezervations");

            migrationBuilder.RenameColumn(
                name: "rezervationStatus",
                table: "Rezervations",
                newName: "RezervationStatus");

            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "Rezervations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_Tours_TourId",
                table: "Rezervations",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "TourId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervations_Tours_TourId",
                table: "Rezervations");

            migrationBuilder.RenameColumn(
                name: "RezervationStatus",
                table: "Rezervations",
                newName: "rezervationStatus");

            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "Rezervations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervations_Tours_TourId",
                table: "Rezervations",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "TourId");
        }
    }
}
