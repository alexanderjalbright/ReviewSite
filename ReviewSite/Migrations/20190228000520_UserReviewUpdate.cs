using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class UserReviewUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 7,
                column: "Comment",
                value: "I'd rather pay for college than this.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 10,
                column: "Comment",
                value: "PICK UP YOUR STARBUCKS CUPS!");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 11,
                column: "Comment",
                value: "I've learned more from 6th graders.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 12,
                column: "Comment",
                value: "I can't see the board.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 13,
                column: "Comment",
                value: "(╯°□°）╯︵ ┻━┻");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 14,
                column: "Comment",
                value: "I think we can all agree that what Kyle would do and what Kyle will do are two different things.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 7,
                column: "Comment",
                value: "Its so close!");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 10,
                column: "Comment",
                value: "The coffee has a peculiar taste.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 11,
                column: "Comment",
                value: "The coffee has a peculiar taste.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 12,
                column: "Comment",
                value: "The coffee has a peculiar taste.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 13,
                column: "Comment",
                value: "The coffee has a peculiar taste.");

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 14,
                column: "Comment",
                value: "The coffee has a peculiar taste.");
        }
    }
}
