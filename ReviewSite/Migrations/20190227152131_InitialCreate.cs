using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    AvgRating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AvgRating", "Category", "ImageURL", "Overview", "Summary", "Title" },
                values: new object[] { 1, null, "Algorithms", "/Images/machinelearning.jpg", "Learn to use machine learning to your advantage.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "Machine Learning" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AvgRating", "Category", "ImageURL", "Overview", "Summary", "Title" },
                values: new object[] { 2, null, "Python", "/Images/pythonforeveryone.jpg", "It really is for everybody!", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "Python For Everybody" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AvgRating", "Category", "ImageURL", "Overview", "Summary", "Title" },
                values: new object[] { 3, null, "What would Kyle do?", "/Images/wwkd.jpg", "It's definitely not for everybody!", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", "WWKD?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
