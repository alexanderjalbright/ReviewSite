using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class ReviewIsNowCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_Reviews_ReviewId",
                table: "UserReviews");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "UserReviews",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_UserReviews_ReviewId",
                table: "UserReviews",
                newName: "IX_UserReviews_CourseId");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "CourseId");

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "UserReviewId", "Comment", "CourseId", "Rating", "UserName" },
                values: new object[] { 15, "I'm just here for the oatmeal.", 3, 3.0m, "mew101" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_Reviews_CourseId",
                table: "UserReviews",
                column: "CourseId",
                principalTable: "Reviews",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_Reviews_CourseId",
                table: "UserReviews");

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 15);

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "UserReviews",
                newName: "ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_UserReviews_CourseId",
                table: "UserReviews",
                newName: "IX_UserReviews_ReviewId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Reviews",
                newName: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_Reviews_ReviewId",
                table: "UserReviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
