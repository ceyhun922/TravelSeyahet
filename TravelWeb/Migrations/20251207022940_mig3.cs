using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentID", "CommentStatus", "CommentUserComment", "CommentUserMail", "CommentUserName", "TourId", "UserId", "WriterId" },
                values: new object[,]
                {
                    { 1, true, "Tur çox gözəl təşkil olunmuşdu, təşəkkürlər!", "aylin@mail.com", "Aylin Məmmədova", null, 1, null },
                    { 2, true, "Qidalanma zəif idi, amma ümumi xidmət yaxşı idi.", "elvin@mail.com", "Elvin Quliyev", null, 2, null },
                    { 3, true, "Bələdçi çox məlumatlı idi, turdan çox razı qaldım.", "nermin@mail.com", "Nərmin Həsənova", null, 3, null },
                    { 4, true, "Qiymət-Performans mükəmməldi, yenə gələcəm.", "murad@mail.com", "Murad Əliyev", null, 4, null },
                    { 5, true, "Çox maraqlı yerləri gəzdik, hər şey super idi.", "gunel@mail.com", "Günel Məmmədli", null, 5, null },
                    { 6, false, "Avtobus bir az gec gəldi amma yenə də xoş keçdi.", "resad@mail.com", "Rəşad Əhmədov", null, 6, null },
                    { 7, true, "Foto zonalar möhtəşəm idi, təşəkkürlər!", "leman@mail.com", "Ləman Əliyeva", null, 7, null },
                    { 8, true, "Tur rəhbəri əla idi, tam peşəkar yanaşma.", "kamran@mail.com", "Kamran Məlikov", null, 8, null },
                    { 9, true, "Bir az yorucu idi, amma görməli yerlər gözəl idi.", "aysel@mail.com", "Aysel Hüseyn", null, 9, null },
                    { 10, true, "Bu, iştirak etdiyim ən yaxşı turlardan biri oldu!", "faiq@mail.com", "Faiq Rzayev", null, 10, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentID",
                keyValue: 10);
        }
    }
}
