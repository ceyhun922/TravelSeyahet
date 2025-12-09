using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mi2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "DestinationCity", "DestinationStatus" },
                values: new object[,]
                {
                    { 1, "Bakı", false },
                    { 2, "Qəbələ", false },
                    { 3, "Şəki", false },
                    { 4, "Quba", false },
                    { 5, "Şuşa", false },
                    { 6, "Lənkəran", false },
                    { 7, "Naftalan", false },
                    { 8, "İsmayıllı", false },
                    { 9, "Qusar", false },
                    { 10, "Zaqatala", false },
                    { 11, "Qazax", false }
                });

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "GuideID", "GuideDescription", "GuideFacebookUrl", "GuideImage", "GuideName", "GuideStatus", "GuideXUrl" },
                values: new object[,]
                {
                    { 1, "Azərbaycanın tarixi yerləri üzrə ixtisaslaşmış bələdçi.", null, "/web/assets/images/team1.jpg", "Ceyhun Əliyev", true, null },
                    { 2, "Qəbələ və Şəki bölgələri üzrə təcrübəli bələdçi.", null, "/web/assets/images/team2.jpg", "Nigar Məmmədova", true, null },
                    { 3, "Bakı şəhərinin mədəni və memarlıq abidələrini tanıdan peşəkar bələdçi.", null, "/web/assets/images/team3.jpg", "Rauf Hüseynov", true, null },
                    { 4, "Azərbaycan mətbəxi və ənənələri barədə tur bələdçisi.", null, "/web/assets/images/team4.jpg", "Günel İsmayılova", true, null },
                    { 5, "Qarabağ və Şuşa istiqamətində tur rəhbəri.", null, "/web/assets/images/team1.jpg", "Elvin Rzayev", true, null },
                    { 6, "Azərbaycanın təbiət parkları və yürüş turları üzrə mütəxəssis.", null, "/web/assets/images/team2.jpg", "Aysel Qasımova", true, null },
                    { 7, "Qobustan və Abşeron yarımadası üzrə ixtisaslaşmış bələdçi.", null, "/web/assets/images/team3.jpg", "Murad Əliyev", true, null },
                    { 8, "Mədəni və incəsənət turları üzrə təcrübəli bələdçi.", null, "/web/assets/images/team4.jpg", "Zəhra Həsənli", true, null },
                    { 9, "İçərişəhər və tarixi Bakı turları üzrə bələdçi.", null, "/web/assets/images/team1.jpg", "Kamal Quliyev", true, null },
                    { 10, "Qusar, Quba və Xaçmaz bölgələri üzrə bələdçi.", null, "/web/assets/images/team2.jpg", "Leyla Səlimova", true, null }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "NotificationId", "NotificationDesc", "NotificationStatus", "NotificationTitle", "NotificationType", "NotificationTypeColor", "NotificationTypeIcon" },
                values: new object[] { 1, "Online Olacaq", true, "Iclas", "warning", "preview-icon bg-success", "mdi mdi-calendar" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "SliderId", "SliderBanner", "SliderStatus", "SliderTitle1", "SliderTitle2" },
                values: new object[] { 1, "/web/assets/images/banner1.jpg", true, "Seyahetin Dadını Çıxart", "Dünyaya Ferqli Bax" });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "TestimonialID", "TestimonialClient", "TestimonialComment", "TestimonialImage", "TestimonialStatus" },
                values: new object[,]
                {
                    { 1, "Eldar Nəsibov", "Tur zamanı hər şey əla idi!", "/web/assets/images/test1.jpg", true },
                    { 2, "Ləman Abbasova", "Bələdçilər çox mehriban idi.", "/web/assets/images/test2.jpg", true },
                    { 3, "Kənan Quliyev", "Maraqlı və rahat səyahət idi.", "/web/assets/images/test3.jpg", true },
                    { 4, "Aytac Nəbiyeva", "Qrup şəklində çox gözəl təşkil olunmuşdu.", "/web/assets/images/test4.jpg", true },
                    { 5, "Rəşad Məmmədli", "Foto məkanlar möhtəşəm idi.", "/web/assets/images/test5.jpg", true },
                    { 6, "Sevda Həsənova", "Ən sevdiyim tur agentliyidir!", "/web/assets/images/test6.jpg", true },
                    { 7, "Orxan Əliyev", "Qarabağ turu inanılmaz idi.", "/web/assets/images/test7.jpg", true },
                    { 8, "Aysel Qasımova", "Təbiət yürüşü çox zövqlü keçdi.", "/web/assets/images/test8.jpg", true },
                    { 9, "Murad Hüseynov", "Təşkilatçılıq yüksək səviyyədə idi.", "/web/assets/images/test9.jpg", true },
                    { 10, "Nigar Məmmədli", "Gələn dəfə də sizlərlə gedəcəm!", "/web/assets/images/test10.jpg", true }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "CommentID", "DTourDayNight", "DestinationId", "GuideID", "TestimonialID", "TourCapaCity", "TourClock", "TourCountLimit", "TourDateTime", "TourDetail", "TourImage", "TourLocaion", "TourPrice", "TourRaiting", "TourStatus", "UserId", "WriterId" },
                values: new object[,]
                {
                    { 1, 1, "1 Gün", 1, 1, 1, 25, new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bakı İçərişəhərin qədim küçələri və Qız qalası ziyarəti.", "/web/assets/images/g1.jpg", "İçərişəhər tarixi turu", 40.0, 5, true, 0, null },
                    { 2, 2, "2 Gün 1 Gecə", 1, 2, 2, 30, new DateTime(2025, 12, 8, 15, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panorama mənzərələri və Xəzər dənizi sahilində gəzinti.", "/web/assets/images/g2.jpg", "Flame Towers və Bulvar turu", 85.0, 4, true, 0, null },
                    { 3, 3, "3 Gün 2 Gecə", 2, 3, 3, 20, new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dağ-xizək istirahəti və Qəbələnin təbiəti.", "/web/assets/images/g3.jpg", "Tufandağ xizək turu", 190.0, 5, true, 0, null },
                    { 4, 4, "1 Gün", 2, 4, 4, 35, new DateTime(2025, 12, 8, 14, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Göl ətrafında rahat gəzinti və piknik.", "/web/assets/images/g4.jpg", "Nohur gölü gəzintisi", 50.0, 4, true, 0, null },
                    { 5, 5, "2 Gün 1 Gecə", 3, 5, 5, 25, new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarixi abidələr və Şəki mətbəxi.", "/web/assets/images/g5.jpg", "Şəki xan sarayı və karvansaray turu", 110.0, 5, true, 0, null },
                    { 6, 6, "1 Gün", 4, 6, 6, 40, new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meşəlikdə yürüş və istirahət.", "/web/assets/images/g6.jpg", "Qəçrəş meşə turu", 60.0, 4, true, 0, null },
                    { 7, 7, "3 Gün 2 Gecə", 4, 7, 7, 20, new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qafqazın ən qədim dağ kəndinə səyahət.", "/web/assets/images/g7.jpg", "Xınalıq kəndi turu", 220.0, 5, true, 0, null },
                    { 8, 8, "2 Gün 1 Gecə", 5, 8, 8, 20, new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qarabağın simvolu olan şəhərdə tarixi gəzinti.", "/web/assets/images/g8.jpg", "Şuşa qalası və Cıdır düz turu", 160.0, 5, true, 0, null },
                    { 9, 9, "2 Gün 1 Gecə", 6, 9, 9, 25, new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ekoturizm və meşə yürüşləri.", "/web/assets/images/g9.jpg", "Hirkan Milli Parkı turu", 130.0, 4, true, 0, null },
                    { 10, 10, "3 Gün 2 Gecə", 7, 10, 10, 30, new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Müalicəvi neft vannaları və spa xidmətləri.", "/web/assets/images/g10.jpg", "Naftalan sanatoriya istirahəti", 200.0, 5, true, 0, null },
                    { 11, 11, "1 Gün", 8, 3, 1, 30, new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Əl işləri və misgərlik sənəti ilə tanışlıq.", "/web/assets/images/g1.jpg", "Lahıc kəndi sənətkarlıq turu", 55.0, 4, true, 0, null },
                    { 12, 12, "3 Gün 2 Gecə", 9, 4, 2, 25, new DateTime(2025, 12, 8, 11, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xizək, dağ yürüşü və qış istirahəti.", "/web/assets/images/g2.jpg", "Şahdağ xizək kompleksi turu", 250.0, 5, true, 0, null },
                    { 13, 13, "2 Gün 1 Gecə", 10, 5, 3, 25, new DateTime(2025, 12, 8, 10, 0, 0, 0, DateTimeKind.Local), 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tarixi qala və təbiət birləşməsi.", "/web/assets/images/g3.jpg", "Zaqatala qalası və mədəni tur", 140.0, 4, true, 0, null },
                    { 14, 14, "1 Gün", 11, 6, 4, 30, new DateTime(2025, 12, 8, 8, 0, 0, 0, DateTimeKind.Local), 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Göyəzən dağının zirvəsinə yürüş və piknik.", "/web/assets/images/g4.jpg", "Göyəzən dağı turu", 60.0, 5, true, 0, null },
                    { 15, 15, "2 Gün 1 Gecə", 11, 7, 5, 20, new DateTime(2025, 12, 8, 12, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qazaxın qədim məscid və qalaları ilə tanışlıq.", "/web/assets/images/g5.jpg", "Qazax tarixi abidələr turu", 125.0, 4, true, 0, null },
                    { 16, 16, "1 Gün", 11, 8, 6, 25, new DateTime(2025, 12, 8, 9, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qazaxın simvolik Sınıq Körpüsünü ziyarət.", "/web/assets/images/g6.jpg", "Sınıq Körpü turu", 45.0, 4, true, 0, null },
                    { 17, 17, "1 Gün", 5, 9, 7, 25, new DateTime(2025, 12, 8, 13, 0, 0, 0, DateTimeKind.Local), 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şuşanın mədəni irsi və mənzərələri.", "/web/assets/images/g7.jpg", "Şuşa şəhər panoraması", 70.0, 5, true, 0, null },
                    { 18, 18, "2 Gün 1 Gecə", 8, 10, 8, 30, new DateTime(2025, 12, 8, 16, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Təbiət gəzintiləri və kamp fəaliyyəti.", "/web/assets/images/g8.jpg", "İsmayıllı meşə yürüşü", 120.0, 4, true, 0, null },
                    { 19, 19, "3 Gün 2 Gecə", 9, 3, 9, 20, new DateTime(2025, 12, 8, 17, 0, 0, 0, DateTimeKind.Local), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qusar dağları boyunca yürüş və düşərgə.", "/web/assets/images/g9.jpg", "Qusar dağ yürüşü", 210.0, 5, true, 0, null },
                    { 20, 20, "2 Gün 1 Gecə", 6, 2, 10, 25, new DateTime(2025, 12, 8, 18, 0, 0, 0, DateTimeKind.Local), 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lənkəran çayı və qədim qalaları ziyarət.", "/web/assets/images/g10.jpg", "Lənkəran çay və qala turu", 135.0, 4, true, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Rotasions",
                columns: new[] { "RotasionID", "RotasionDescription", "RotasionName", "RotasionStatus", "TourId" },
                values: new object[,]
                {
                    { 1, "Bakı İçərişəhərin simvolu, tarixi abidə.", "Qız Qalası", true, 1 },
                    { 2, "Orta əsr memarlığının incisi.", "Şirvanşahlar Sarayı", true, 1 },
                    { 3, "Xəzər sahili boyunca səyahət və foto çəkilişlər.", "Bulvar Gəzintisi", true, 2 },
                    { 4, "Bakı gecəsinin parlayan simvolu.", "Flame Towers Panorama", true, 2 },
                    { 5, "Xizək və teleferik macərası.", "Tufandağ Kompleksi", true, 3 },
                    { 6, "Qəbələnd əyləncə parkında istirahət.", "Qəbələ Əyləncə Mərkəzi", true, 3 },
                    { 7, "Təbiət qoynunda sakitlik və foto turları.", "Nohur Gölü", true, 4 },
                    { 8, "Dağlıq ərazidə gəzinti və sərin hava.", "Yeddi Gözəl Şəlaləsi", true, 4 },
                    { 9, "Şəki xanlarının tarixi iqamətgahı.", "Xan Sarayı", true, 5 },
                    { 10, "İpək Yolu üzərində qədim karvansaray kompleksi.", "Karvansaray", true, 5 },
                    { 11, "Qafqazın ən qədim kilsələrindən biri.", "Kiş Kilsəsi", true, 5 },
                    { 12, "Meşəlikdə yürüş və piknik.", "Qəçrəş Meşəsi", true, 6 },
                    { 13, "Təbiətin nadir gözəlliyi, dağlıq ərazi.", "Afurd Şəlaləsi", true, 6 },
                    { 14, "Qafqazın ən qədim yaşayış məskəni.", "Xınalıq Kəndi", true, 7 },
                    { 15, "Unikal yəhudi məhəlləsi və mədəniyyət.", "Quba Qırmızı Qəsəbə", true, 7 },
                    { 16, "Qarabağın ürəyində tarixi qala.", "Şuşa Qalası", true, 8 },
                    { 17, "Qarabağ mənzərələri və açıq hava tədbirləri.", "Cıdır Düzü", true, 8 },
                    { 18, "İslam memarlığının incisi.", "Gövhər Ağa Məscidi", true, 8 },
                    { 19, "Ekoturizm və dağ yürüşləri.", "Hirkan Meşəsi", true, 9 },
                    { 20, "Dəniz kənarında gün batımı.", "Mayak Sahili", true, 9 },
                    { 21, "Naftalan neft vannası və sağlamlıq mərkəzi.", "Sanatoriya Kompleksi", true, 10 },
                    { 22, "Şəhər parkında istirahət və gəzinti.", "Naftalan Parkı", true, 10 },
                    { 23, "Misgərlik və əl sənətkarlıq mərkəzi.", "Lahıc Kəndi", true, 11 },
                    { 24, "Kənd həyatı və yerli mədəniyyət.", "Basqal Kəndi", true, 11 },
                    { 25, "Dağ yürüşü və teleferik səyahəti.", "Şahdağ Dağ Yolu", true, 12 },
                    { 26, "Dağlıq kənd həyatı və foto turlar.", "Ləzə Kəndi", true, 12 },
                    { 27, "Tarixi qala və şəhər mənzərələri.", "Zaqatala Qalası", true, 13 },
                    { 28, "Mədəni kənd turu və yerli mətbəx.", "Yuxarı Çardaqlar", true, 13 },
                    { 29, "Zirvəyə yürüş və mənzərəli foto turları.", "Göyəzən Dağı", true, 14 },
                    { 30, "Tarixi abidə və Qazax çayı ətrafı gəzinti.", "Sınıq Körpü", true, 16 },
                    { 31, "Qazaxın qədim müdafiə istehkamı.", "Qazax Qalası", true, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notifications",
                keyColumn: "NotificationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rotasions",
                keyColumn: "RotasionID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "SliderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "DestinationId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Guides",
                keyColumn: "GuideID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "TestimonialID",
                keyValue: 10);
        }
    }
}
