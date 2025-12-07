using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDetail = table.Column<int>(type: "int", nullable: false),
                    AboutImage1 = table.Column<int>(type: "int", nullable: false),
                    AboutTitle2 = table.Column<int>(type: "int", nullable: false),
                    AboutStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Abouts2",
                columns: table => new
                {
                    About2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About2Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Description = table.Column<int>(type: "int", nullable: false),
                    About2Image = table.Column<int>(type: "int", nullable: false),
                    AboutStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts2", x => x.About2ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureID);
                });

            migrationBuilder.CreateTable(
                name: "Features2",
                columns: table => new
                {
                    Feature2ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feature2Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features2", x => x.Feature2ID);
                });

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    GuideID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuideName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideFacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideXUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuideStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.GuideID);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationTypeColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationTypeIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NotificationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderBanner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "SubAbouts",
                columns: table => new
                {
                    SubAboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubAboutImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubAboutStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAbouts", x => x.SubAboutID);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    TestimonialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestimonialClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestimonialStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.TestimonialID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourLocaion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DTourDayNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourPrice = table.Column<double>(type: "float", nullable: false),
                    TourImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourCapaCity = table.Column<int>(type: "int", nullable: false),
                    TourCountLimit = table.Column<int>(type: "int", nullable: false),
                    TourRaiting = table.Column<int>(type: "int", nullable: false),
                    TourStatus = table.Column<bool>(type: "bit", nullable: false),
                    TourDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourClock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    GuideID = table.Column<int>(type: "int", nullable: false),
                    TestimonialID = table.Column<int>(type: "int", nullable: false),
                    CommentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_AspNetUsers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tours_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tours_Guides_GuideID",
                        column: x => x.GuideID,
                        principalTable: "Guides",
                        principalColumn: "GuideID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_Testimonials_TestimonialID",
                        column: x => x.TestimonialID,
                        principalTable: "Testimonials",
                        principalColumn: "TestimonialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentUserMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentUserComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    TourId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId");
                });

            migrationBuilder.CreateTable(
                name: "Rezervations",
                columns: table => new
                {
                    RezervationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervationCountPerson = table.Column<int>(type: "int", nullable: false),
                    RezervationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RezervationDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RezervationStatus = table.Column<int>(type: "int", nullable: false),
                    RezervationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RezervationTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    RemainderCapaCity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervations", x => x.RezervationID);
                    table.ForeignKey(
                        name: "FK_Rezervations_AspNetUsers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rezervations_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervations_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rotasions",
                columns: table => new
                {
                    RotasionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RotasionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotasionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotasionStatus = table.Column<bool>(type: "bit", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotasions", x => x.RotasionID);
                    table.ForeignKey(
                        name: "FK_Rotasions_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "TourId", "CommentID", "DTourDayNight", "DestinationId", "GuideID", "TestimonialID", "TourCapaCity", "TourClock", "TourCountLimit", "TourDetail", "TourImage", "TourLocaion", "TourPrice", "TourRaiting", "TourStatus", "UserId", "WriterId" },
                values: new object[,]
                {
                    { 1, 1, "1 Gün", 1, 1, 1, 25, new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Local), 5, "Bakı İçərişəhərin qədim küçələri və Qız qalası ziyarəti.", "/web/assets/images/g1.jpg", "İçərişəhər tarixi turu", 40.0, 0, true, 0, null },
                    { 2, 2, "2 Gün 1 Gecə", 1, 2, 2, 30, new DateTime(2025, 12, 7, 15, 0, 0, 0, DateTimeKind.Local), 8, "Panorama mənzərələri və Xəzər dənizi sahilində gəzinti.", "/web/assets/images/g2.jpg", "Flame Towers və Bulvar turu", 85.0, 0, true, 0, null },
                    { 3, 3, "3 Gün 2 Gecə", 2, 3, 3, 20, new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 5, "Dağ-xizək istirahəti və Qəbələnin təbiəti.", "/web/assets/images/g3.jpg", "Tufandağ xizək turu", 190.0, 0, true, 0, null },
                    { 4, 4, "1 Gün", 2, 4, 4, 35, new DateTime(2025, 12, 7, 14, 0, 0, 0, DateTimeKind.Local), 10, "Göl ətrafında rahat gəzinti və piknik.", "/web/assets/images/g4.jpg", "Nohur gölü gəzintisi", 50.0, 0, true, 0, null },
                    { 5, 5, "2 Gün 1 Gecə", 3, 5, 5, 25, new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Local), 7, "Tarixi abidələr və Şəki mətbəxi.", "/web/assets/images/g5.jpg", "Şəki xan sarayı və karvansaray turu", 110.0, 0, true, 0, null },
                    { 6, 6, "1 Gün", 4, 6, 6, 40, new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 10, "Meşəlikdə yürüş və istirahət.", "/web/assets/images/g6.jpg", "Qəçrəş meşə turu", 60.0, 0, true, 0, null },
                    { 7, 7, "3 Gün 2 Gecə", 4, 7, 7, 20, new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 5, "Qafqazın ən qədim dağ kəndinə səyahət.", "/web/assets/images/g7.jpg", "Xınalıq kəndi turu", 220.0, 0, true, 0, null },
                    { 8, 8, "2 Gün 1 Gecə", 5, 8, 8, 20, new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 6, "Qarabağın simvolu olan şəhərdə tarixi gəzinti.", "/web/assets/images/g8.jpg", "Şuşa qalası və Cıdır düz turu", 160.0, 0, true, 0, null },
                    { 9, 9, "2 Gün 1 Gecə", 6, 9, 9, 25, new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Local), 8, "Ekoturizm və meşə yürüşləri.", "/web/assets/images/g9.jpg", "Hirkan Milli Parkı turu", 130.0, 0, true, 0, null },
                    { 10, 10, "3 Gün 2 Gecə", 7, 10, 10, 30, new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Local), 10, "Müalicəvi neft vannaları və spa xidmətləri.", "/web/assets/images/g10.jpg", "Naftalan sanatoriya istirahəti", 200.0, 0, true, 0, null },
                    { 11, 11, "1 Gün", 8, 3, 1, 30, new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 10, "Əl işləri və misgərlik sənəti ilə tanışlıq.", "/web/assets/images/g1.jpg", "Lahıc kəndi sənətkarlıq turu", 55.0, 0, true, 0, null },
                    { 12, 12, "3 Gün 2 Gecə", 9, 4, 2, 25, new DateTime(2025, 12, 7, 11, 0, 0, 0, DateTimeKind.Local), 5, "Xizək, dağ yürüşü və qış istirahəti.", "/web/assets/images/g2.jpg", "Şahdağ xizək kompleksi turu", 250.0, 0, true, 0, null },
                    { 13, 13, "2 Gün 1 Gecə", 10, 5, 3, 25, new DateTime(2025, 12, 7, 10, 0, 0, 0, DateTimeKind.Local), 6, "Tarixi qala və təbiət birləşməsi.", "/web/assets/images/g3.jpg", "Zaqatala qalası və mədəni tur", 140.0, 0, true, 0, null },
                    { 14, 14, "1 Gün", 11, 6, 4, 30, new DateTime(2025, 12, 7, 8, 0, 0, 0, DateTimeKind.Local), 10, "Göyəzən dağının zirvəsinə yürüş və piknik.", "/web/assets/images/g4.jpg", "Göyəzən dağı turu", 60.0, 0, true, 0, null },
                    { 15, 15, "2 Gün 1 Gecə", 11, 7, 5, 20, new DateTime(2025, 12, 7, 12, 0, 0, 0, DateTimeKind.Local), 5, "Qazaxın qədim məscid və qalaları ilə tanışlıq.", "/web/assets/images/g5.jpg", "Qazax tarixi abidələr turu", 125.0, 0, true, 0, null },
                    { 16, 16, "1 Gün", 11, 8, 6, 25, new DateTime(2025, 12, 7, 9, 0, 0, 0, DateTimeKind.Local), 8, "Qazaxın simvolik Sınıq Körpüsünü ziyarət.", "/web/assets/images/g6.jpg", "Sınıq Körpü turu", 45.0, 0, true, 0, null },
                    { 17, 17, "1 Gün", 5, 9, 7, 25, new DateTime(2025, 12, 7, 13, 0, 0, 0, DateTimeKind.Local), 7, "Şuşanın mədəni irsi və mənzərələri.", "/web/assets/images/g7.jpg", "Şuşa şəhər panoraması", 70.0, 0, true, 0, null },
                    { 18, 18, "2 Gün 1 Gecə", 8, 10, 8, 30, new DateTime(2025, 12, 7, 16, 0, 0, 0, DateTimeKind.Local), 8, "Təbiət gəzintiləri və kamp fəaliyyəti.", "/web/assets/images/g8.jpg", "İsmayıllı meşə yürüşü", 120.0, 0, true, 0, null },
                    { 19, 19, "3 Gün 2 Gecə", 9, 3, 9, 20, new DateTime(2025, 12, 7, 17, 0, 0, 0, DateTimeKind.Local), 5, "Qusar dağları boyunca yürüş və düşərgə.", "/web/assets/images/g9.jpg", "Qusar dağ yürüşü", 210.0, 0, true, 0, null },
                    { 20, 20, "2 Gün 1 Gecə", 6, 2, 10, 25, new DateTime(2025, 12, 7, 18, 0, 0, 0, DateTimeKind.Local), 8, "Lənkəran çayı və qədim qalaları ziyarət.", "/web/assets/images/g10.jpg", "Lənkəran çay və qala turu", 135.0, 0, true, 0, null }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TourId",
                table: "Comments",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WriterId",
                table: "Comments",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_DestinationId",
                table: "Rezervations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_TourId",
                table: "Rezervations",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_WriterId",
                table: "Rezervations",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Rotasions_TourId",
                table: "Rotasions",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_DestinationId",
                table: "Tours",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_GuideID",
                table: "Tours",
                column: "GuideID");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TestimonialID",
                table: "Tours",
                column: "TestimonialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_WriterId",
                table: "Tours",
                column: "WriterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Abouts2");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Features2");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Rezervations");

            migrationBuilder.DropTable(
                name: "Rotasions");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SubAbouts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
