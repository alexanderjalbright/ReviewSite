using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class UserReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reviews",
                newName: "ReviewId");

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
                table: "UserReviews",
                columns: new[] { "UserReviewId", "Comment", "Rating", "ReviewId", "UserName" },
                values: new object[,]
                {
                    { 1, "Its free!", 3.3m, 1, "MoocJunkie" },
                    { 2, "You get what you pay for and it's free.", 4.1m, 1, "SwagYoloFleekDabs" },
                    { 3, "The instructors are racist.", 3.9m, 1, "xXx_DragonSlayer_xXx" },
                    { 4, "The instructors love you like their own family!", 4.9m, 2, "JoeLovesFishing_USA" },
                    { 5, "If I could experience Groundhog Day here, I'd still never get enough.", 5.0m, 2, "elDiablo1992" },
                    { 6, "This place attracts weirdos.", 4.1m, 2, "W3CanC0d31T" },
                    { 7, "Its so close!", 2.2m, 3, "anegronjr" },
                    { 8, "The carpets smell like urine.", 1.7m, 3, "alexanderjalbright" },
                    { 9, "The coffee has a peculiar taste.", 2.2m, 3, "khanishvili" },
                    { 10, "The coffee has a peculiar taste.", 2.3m, 3, "jen3ten" },
                    { 11, "The coffee has a peculiar taste.", 2.0m, 3, "MaryMcGeary" },
                    { 12, "The coffee has a peculiar taste.", 1.5m, 3, "mroyski" },
                    { 13, "The coffee has a peculiar taste.", 3.0m, 3, "aldenmolina" },
                    { 14, "The coffee has a peculiar taste.", 3.0m, 3, "JoeScheiman" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ReviewId",
                table: "UserReviews",
                column: "ReviewId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "Id");
        }
    }
}
