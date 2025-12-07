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
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Testimonials_TestimonialID",
                table: "Tours");

            migrationBuilder.AlterColumn<int>(
                name: "TestimonialID",
                table: "Tours",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Testimonials_TestimonialID",
                table: "Tours",
                column: "TestimonialID",
                principalTable: "Testimonials",
                principalColumn: "TestimonialID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Testimonials_TestimonialID",
                table: "Tours");

            migrationBuilder.AlterColumn<int>(
                name: "TestimonialID",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Testimonials_TestimonialID",
                table: "Tours",
                column: "TestimonialID",
                principalTable: "Testimonials",
                principalColumn: "TestimonialID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
