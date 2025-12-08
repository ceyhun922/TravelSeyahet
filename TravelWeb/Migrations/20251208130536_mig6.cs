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
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Tours_TourId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 5,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 6,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 7,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 8,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 9,
                column: "TourId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 10,
                column: "TourId",
                value: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Tours_TourId",
                table: "Comments",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "TourId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Tours_TourId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 5,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 6,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 7,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 8,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 9,
                column: "TourId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 10,
                column: "TourId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Tours_TourId",
                table: "Comments",
                column: "TourId",
                principalTable: "Tours",
                principalColumn: "TourId");
        }
    }
}
