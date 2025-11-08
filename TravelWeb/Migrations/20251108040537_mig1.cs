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
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationDayNight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationPrice = table.Column<double>(type: "float", nullable: false),
                    DestinationImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapaCity = table.Column<int>(type: "int", nullable: false),
                    DestinationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DestinationCountLimit = table.Column<int>(type: "int", nullable: false),
                    DestinationStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    WriterId = table.Column<int>(type: "int", nullable: true),
                    GuideID = table.Column<int>(type: "int", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestimonialID = table.Column<int>(type: "int", nullable: false),
                    CommentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                    table.ForeignKey(
                        name: "FK_Destinations_AspNetUsers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Destinations_Guides_GuideID",
                        column: x => x.GuideID,
                        principalTable: "Guides",
                        principalColumn: "GuideID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Destinations_Testimonials_TestimonialID",
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
                    DestinationId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Comments_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId");
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
                    DestinationId = table.Column<int>(type: "int", nullable: false)
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
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotasions", x => x.RotasionID);
                    table.ForeignKey(
                        name: "FK_Rotasions_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Destinations",
                columns: new[] { "DestinationId", "CapaCity", "CommentID", "DestinationCity", "DestinationCountLimit", "DestinationDayNight", "DestinationImage", "DestinationPrice", "DestinationStatus", "DestinationTime", "Guid", "GuideID", "TestimonialID", "UserId", "WriterId" },
                values: new object[,]
                {
                    { 1, 25, 0, "Bakı", 30, "3 gün 2 gecə", "/web/assets/images/g1.jpg", 350.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1480), new Guid("00000000-0000-0000-0000-000000000000"), 1, 1, 1, null },
                    { 2, 20, 0, "Qəbələ", 25, "2 gün 1 gecə", "/web/assets/images/g2.jpg", 250.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1480), new Guid("00000000-0000-0000-0000-000000000000"), 2, 2, 2, null },
                    { 3, 15, 0, "Şəki", 20, "1 günlük tur", "/web/assets/images/g3.jpg", 180.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1490), new Guid("00000000-0000-0000-0000-000000000000"), 3, 3, 3, null },
                    { 4, 20, 0, "Quba", 25, "3 gün 2 gecə", "/web/assets/images/g4.jpg", 300.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1490), new Guid("00000000-0000-0000-0000-000000000000"), 4, 4, 1, null },
                    { 5, 30, 0, "Şuşa", 30, "4 gün 3 gecə", "/web/assets/images/g5.jpg", 400.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1490), new Guid("00000000-0000-0000-0000-000000000000"), 5, 5, 2, null },
                    { 6, 20, 0, "Lənkəran", 25, "2 gün 1 gecə", "/web/assets/images/g6.jpg", 270.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1500), new Guid("00000000-0000-0000-0000-000000000000"), 6, 6, 3, null },
                    { 7, 25, 0, "Naftalan", 30, "3 gün 2 gecə", "/web/assets/images/g7.jpg", 320.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1500), new Guid("00000000-0000-0000-0000-000000000000"), 7, 7, 1, null },
                    { 8, 15, 0, "İsmayıllı", 20, "1 günlük tur", "/web/assets/images/g8.jpg", 190.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1500), new Guid("00000000-0000-0000-0000-000000000000"), 8, 8, 2, null },
                    { 9, 20, 0, "Qusar", 25, "2 gün 1 gecə", "/web/assets/images/g9.jpg", 260.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1510), new Guid("00000000-0000-0000-0000-000000000000"), 9, 9, 3, null },
                    { 10, 25, 0, "Zaqatala", 30, "3 gün 2 gecə", "/web/assets/images/g10.jpg", 310.0, true, new DateTime(2025, 11, 8, 8, 5, 36, 811, DateTimeKind.Local).AddTicks(1510), new Guid("00000000-0000-0000-0000-000000000000"), 10, 10, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Rotasions",
                columns: new[] { "RotasionID", "DestinationId", "RotasionDescription", "RotasionName", "RotasionStatus" },
                values: new object[,]
                {
                    { 1, 1, "Tarixi abidələrə səyahət", "Qobustan Qayaüstü", true },
                    { 2, 2, "Təbiət gəzintisi və foto turları", "Nohur Gölü", true },
                    { 3, 3, "Mədəni ekskursiya", "Xan Sarayı", true },
                    { 4, 4, "Dağ yürüşü və piknik", "Qəçrəş Meşəsi", true },
                    { 5, 5, "Qarabağın ürəyi olan şəhər", "Qalasına Ziyarət", true },
                    { 6, 5, "Çay bağları və təbiət", "Xalça Müzeyi", true },
                    { 7, 7, "Spa və sağlamlıq turu", "Naftalan Müalicə Mərkəzi", true },
                    { 8, 8, "Ekoturizm və hiking", "İsmayıllı Meşələri", true },
                    { 9, 9, "Qar idmanı və xizək turu", "Qış Mərkəzi", true },
                    { 10, 10, "Təbiət və heyvanat dünyası ilə tanışlıq", "Qoruğ", true }
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
                name: "IX_Comments_DestinationId",
                table: "Comments",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_WriterId",
                table: "Comments",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_GuideID",
                table: "Destinations",
                column: "GuideID");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_TestimonialID",
                table: "Destinations",
                column: "TestimonialID");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_WriterId",
                table: "Destinations",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_DestinationId",
                table: "Rezervations",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervations_WriterId",
                table: "Rezervations",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Rotasions_DestinationId",
                table: "Rotasions",
                column: "DestinationId");
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
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Testimonials");
        }
    }
}
