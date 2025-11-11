using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelWeb.Migrations
{
    /// <inheritdoc />
    public partial class mig_seed_fix : Migration
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
                    TourId = table.Column<int>(type: "int", nullable: false)
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
                    TourStatus = table.Column<bool>(type: "bit", nullable: false),
                    TourDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourClock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    GuideID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    rezervationStatus = table.Column<int>(type: "int", nullable: false),
                    RezervationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RezervationTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    RemainderCapaCity = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Rezervations_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId");
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
                columns: new[] { "DestinationId", "DestinationCity", "TourId" },
                values: new object[,]
                {
                    { 1, "Bakı", 0 },
                    { 2, "Qəbələ", 0 },
                    { 3, "Şəki", 0 },
                    { 4, "Quba", 0 },
                    { 5, "Şuşa", 0 },
                    { 6, "Lənkəran", 0 },
                    { 7, "Naftalan", 0 },
                    { 8, "İsmayıllı", 0 },
                    { 9, "Qusar", 0 },
                    { 10, "Zaqatala", 0 }
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
                columns: new[] { "TourId", "CommentID", "DTourDayNight", "DestinationId", "Guid", "GuideID", "TestimonialID", "TourCapaCity", "TourClock", "TourCountLimit", "TourDetail", "TourImage", "TourLocaion", "TourPrice", "TourStatus", "UserId", "WriterId" },
                values: new object[,]
                {
                    { 1, 0, null, 1, new Guid("00000000-0000-0000-0000-000000000000"), 1, 1, 0, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), 0, "Tarixi şəhər turu", null, "İçərişəhər turu", 0.0, true, null, null },
                    { 2, 0, null, 1, new Guid("00000000-0000-0000-0000-000000000000"), 2, 2, 0, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), 0, "Bulvar gəzintisi", null, "Dənizkənarı Bulvar turu", 0.0, true, null, null },
                    { 3, 0, null, 1, new Guid("00000000-0000-0000-0000-000000000000"), 3, 3, 0, new DateTime(2025, 11, 11, 20, 0, 0, 0, DateTimeKind.Local), 0, "Panorama turları", null, "Flame Towers turu", 0.0, true, null, null },
                    { 4, 0, null, 2, new Guid("00000000-0000-0000-0000-000000000000"), 3, 4, 0, new DateTime(2025, 11, 11, 10, 0, 0, 0, DateTimeKind.Local), 0, "Dağ-xizək turu", null, "Tufandağ turu", 0.0, true, null, null },
                    { 5, 0, null, 2, new Guid("00000000-0000-0000-0000-000000000000"), 4, 5, 0, new DateTime(2025, 11, 11, 15, 0, 0, 0, DateTimeKind.Local), 0, "Göl ətrafında gəzinti", null, "Nohur gölü turu", 0.0, true, null, null },
                    { 6, 0, null, 2, new Guid("00000000-0000-0000-0000-000000000000"), 5, 6, 0, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), 0, "Tarixi tur", null, "Qəbələ Qədim şəhəri turu", 0.0, true, null, null },
                    { 7, 0, null, 3, new Guid("00000000-0000-0000-0000-000000000000"), 6, 7, 0, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), 0, "Mədəniyyət turu", null, "Şəki xan sarayı turu", 0.0, true, null, null },
                    { 8, 0, null, 3, new Guid("00000000-0000-0000-0000-000000000000"), 7, 8, 0, new DateTime(2025, 11, 11, 13, 0, 0, 0, DateTimeKind.Local), 0, "Tarixi kilsə turları", null, "Kiş kəndi turu", 0.0, true, null, null },
                    { 9, 0, null, 3, new Guid("00000000-0000-0000-0000-000000000000"), 7, 9, 0, new DateTime(2025, 11, 11, 18, 0, 0, 0, DateTimeKind.Local), 0, "Şirniyyat turu", null, "Şəki bazarı turu", 0.0, true, null, null },
                    { 10, 0, null, 4, new Guid("00000000-0000-0000-0000-000000000000"), 5, 10, 0, new DateTime(2025, 11, 11, 8, 0, 0, 0, DateTimeKind.Local), 0, "Meşə turu", null, "Qəçrəş turu", 0.0, true, null, null },
                    { 11, 0, null, 4, new Guid("00000000-0000-0000-0000-000000000000"), 8, 1, 0, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), 0, "Dağ kəndi turu", null, "Xınalıq turu", 0.0, true, null, null },
                    { 12, 0, null, 4, new Guid("00000000-0000-0000-0000-000000000000"), 9, 2, 0, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), 0, "Çay ətrafında gəzinti", null, "Qudyalçay turu", 0.0, true, null, null },
                    { 13, 0, null, 5, new Guid("00000000-0000-0000-0000-000000000000"), 7, 3, 0, new DateTime(2025, 11, 11, 10, 0, 0, 0, DateTimeKind.Local), 0, "Tarixi mədəni tur", null, "Cıdır düz turu", 0.0, true, null, null },
                    { 14, 0, null, 5, new Guid("00000000-0000-0000-0000-000000000000"), 9, 4, 0, new DateTime(2025, 11, 11, 15, 0, 0, 0, DateTimeKind.Local), 0, "Mədəni abidələr turu", null, "Yuxarı Gövhər Ağa məscidi turu", 0.0, true, null, null },
                    { 15, 0, null, 5, new Guid("00000000-0000-0000-0000-000000000000"), 10, 5, 0, new DateTime(2025, 11, 11, 20, 0, 0, 0, DateTimeKind.Local), 0, "Qala turu", null, "Şuşa qalası turu", 0.0, true, null, null },
                    { 16, 0, null, 6, new Guid("00000000-0000-0000-0000-000000000000"), 9, 6, 0, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), 0, "Ekoturizm", null, "Hirkan Milli Parkı turu", 0.0, true, null, null },
                    { 17, 0, null, 6, new Guid("00000000-0000-0000-0000-000000000000"), 10, 7, 0, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), 0, "Dəniz gəzintisi", null, "Mayak sahili turu", 0.0, true, null, null },
                    { 18, 0, null, 6, new Guid("00000000-0000-0000-0000-000000000000"), 6, 8, 0, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), 0, "Tarixi yerlər turu", null, "Lənkəran qalası turu", 0.0, true, null, null },
                    { 19, 0, null, 7, new Guid("00000000-0000-0000-0000-000000000000"), 10, 9, 0, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), 0, "Müalicəvi istirahət", null, "Naftalan sanatoriyası turu", 0.0, true, null, null },
                    { 20, 0, null, 7, new Guid("00000000-0000-0000-0000-000000000000"), 5, 10, 0, new DateTime(2025, 11, 11, 13, 0, 0, 0, DateTimeKind.Local), 0, "Şəhər gəzintisi", null, "Naftalan şəhər mərkəzi turu", 0.0, true, null, null },
                    { 21, 0, null, 7, new Guid("00000000-0000-0000-0000-000000000000"), 5, 1, 0, new DateTime(2025, 11, 11, 18, 0, 0, 0, DateTimeKind.Local), 0, "Açıq hava fəaliyyəti", null, "Naftalan parkı turu", 0.0, true, null, null },
                    { 22, 0, null, 8, new Guid("00000000-0000-0000-0000-000000000000"), 3, 2, 0, new DateTime(2025, 11, 11, 8, 0, 0, 0, DateTimeKind.Local), 0, "Əl sənətkarlıq turu", null, "Lahıc kəndi turu", 0.0, true, null, null },
                    { 23, 0, null, 8, new Guid("00000000-0000-0000-0000-000000000000"), 5, 3, 0, new DateTime(2025, 11, 11, 14, 0, 0, 0, DateTimeKind.Local), 0, "Təbiət gəzintisi", null, "İsmayıllı meşələri turu", 0.0, true, null, null },
                    { 24, 0, null, 8, new Guid("00000000-0000-0000-0000-000000000000"), 3, 4, 0, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), 0, "Mədəni tur", null, "Basqal kəndi turu", 0.0, true, null, null },
                    { 25, 0, null, 9, new Guid("00000000-0000-0000-0000-000000000000"), 9, 5, 0, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), 0, "Xizək turu", null, "Şahdağ turu", 0.0, true, null, null },
                    { 26, 0, null, 9, new Guid("00000000-0000-0000-0000-000000000000"), 4, 6, 0, new DateTime(2025, 11, 11, 15, 0, 0, 0, DateTimeKind.Local), 0, "Ailəvi istirahət", null, "Qusar şəhər parkı turu", 0.0, true, null, null },
                    { 27, 0, null, 9, new Guid("00000000-0000-0000-0000-000000000000"), 9, 7, 0, new DateTime(2025, 11, 11, 20, 0, 0, 0, DateTimeKind.Local), 0, "Dağ yürüşü", null, "Ləzə kəndi turu", 0.0, true, null, null },
                    { 28, 0, null, 10, new Guid("00000000-0000-0000-0000-000000000000"), 8, 8, 0, new DateTime(2025, 11, 11, 9, 0, 0, 0, DateTimeKind.Local), 0, "Tarixi tur", null, "Zaqatala qalası turu", 0.0, true, null, null },
                    { 29, 0, null, 10, new Guid("00000000-0000-0000-0000-000000000000"), 2, 9, 0, new DateTime(2025, 11, 11, 13, 0, 0, 0, DateTimeKind.Local), 0, "Mədəni kənd turu", null, "Yuxarı Çardaqlar turu", 0.0, true, null, null },
                    { 30, 0, null, 10, new Guid("00000000-0000-0000-0000-000000000000"), 1, 10, 0, new DateTime(2025, 11, 11, 19, 0, 0, 0, DateTimeKind.Local), 0, "Təbiət və mədəniyyət turu", null, "Qalal kəndi turu", 0.0, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Rotasions",
                columns: new[] { "RotasionID", "RotasionDescription", "RotasionName", "RotasionStatus", "TourId" },
                values: new object[,]
                {
                    { 1, "Tarixi abidələrə səyahət", "Qobustan Qayaüstü", true, 1 },
                    { 2, "Təbiət gəzintisi və foto turları", "Nohur Gölü", true, 5 },
                    { 3, "Mədəni ekskursiya", "Xan Sarayı", true, 7 },
                    { 4, "Dağ yürüşü və piknik", "Qəçrəş Meşəsi", true, 10 },
                    { 5, "Qarabağın ürəyi", "Şuşa qalası", true, 15 },
                    { 6, "Spa və sağlamlıq turu", "Naftalan Müalicə Mərkəzi", true, 19 },
                    { 7, "Ekoturizm və hiking", "İsmayıllı Meşələri", true, 23 },
                    { 8, "Qar idmanı və xizək", "Şahdağ Mərkəzi", true, 25 },
                    { 9, "Tarixi səfər", "Zaqatala Qalası", true, 28 }
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
