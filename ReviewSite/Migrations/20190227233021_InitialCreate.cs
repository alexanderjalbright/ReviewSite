using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: true),
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageURL = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    AvgRating = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    UserReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Rating = table.Column<decimal>(nullable: false),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.UserReviewId);
                    table.ForeignKey(
                        name: "FK_UserReviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "C#" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Python" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AvgRating", "CategoryId", "ImageURL", "Overview", "Summary", "Title" },
                values: new object[] { 1, null, 1, "/Images/machinelearning.jpg", "Learn to use machine learning to your advantage.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "Machine Learning" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AvgRating", "CategoryId", "ImageURL", "Overview", "Summary", "Title" },
                values: new object[] { 3, null, 1, "/Images/wwkd.jpg", "What would Kyle do?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "WWKD?" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AvgRating", "CategoryId", "ImageURL", "Overview", "Summary", "Title" },
                values: new object[] { 2, null, 2, "/Images/pythonforeveryone.jpg", "It really is for everybody!", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "Python For Everybody" });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "UserReviewId", "Comment", "Rating", "ReviewId", "UserName" },
                values: new object[,]
                {
                    { 1, "Its free!", 3.3m, 1, "MoocJunkie" },
                    { 2, "You get what you pay for and it's free.", 4.1m, 1, "SwagYoloFleekDabs" },
                    { 3, "The instructors are racist.", 3.9m, 1, "xXx_DragonSlayer_xXx" },
                    { 7, "Its so close!", 2.2m, 3, "anegronjr" },
                    { 8, "The carpets smell like urine.", 1.7m, 3, "alexanderjalbright" },
                    { 9, "The coffee has a peculiar taste.", 2.2m, 3, "khanishvili" },
                    { 10, "The coffee has a peculiar taste.", 2.3m, 3, "jen3ten" },
                    { 11, "The coffee has a peculiar taste.", 2.0m, 3, "MaryMcGeary" },
                    { 12, "The coffee has a peculiar taste.", 1.5m, 3, "mroyski" },
                    { 13, "The coffee has a peculiar taste.", 3.0m, 3, "aldenmolina" },
                    { 14, "The coffee has a peculiar taste.", 3.0m, 3, "JoeScheiman" },
                    { 4, "The instructors love you like their own family!", 4.9m, 2, "JoeLovesFishing_USA" },
                    { 5, "If I could experience Groundhog Day here, I'd still never get enough.", 5.0m, 2, "elDiablo1992" },
                    { 6, "This place attracts weirdos.", 4.1m, 2, "W3CanC0d31T" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryId",
                table: "Reviews",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ReviewId",
                table: "UserReviews",
                column: "ReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
