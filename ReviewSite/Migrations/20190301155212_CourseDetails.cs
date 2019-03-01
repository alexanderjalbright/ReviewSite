using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewSite.Migrations
{
    public partial class CourseDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Reviews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StartDate",
                table: "Reviews",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "Duration", "StartDate" },
                values: new object[] { "16 Weeks", "August 2nd, 2019" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "Duration", "StartDate" },
                values: new object[] { "12 Weeks", "August 3rd, 2019" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "Duration", "StartDate" },
                values: new object[] { "14 Weeks", "August 4th, 2019" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Reviews");
        }
    }
}
