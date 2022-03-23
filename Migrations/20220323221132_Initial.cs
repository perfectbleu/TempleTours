using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTours.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appts",
                columns: table => new
                {
                    ApptId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appts", x => x.ApptId);
                });

            migrationBuilder.CreateTable(
                name: "ApptTimes",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DayOfAppt = table.Column<string>(nullable: true),
                    TimeOfAppt = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApptTimes", x => x.TimeId);
                });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 1, true, "Sunday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 66, true, "Friday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 65, true, "Thursday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 64, true, "Thursday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 63, true, "Thursday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 62, true, "Thursday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 61, true, "Thursday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 60, true, "Thursday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 59, true, "Thursday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 58, true, "Thursday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 57, true, "Thursday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 56, true, "Thursday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 55, true, "Thursday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 54, true, "Thursday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 53, true, "Thursday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 52, true, "Wednesday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 51, true, "Wednesday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 50, true, "Wednesday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 49, true, "Wednesday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 48, true, "Wednesday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 67, true, "Friday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 47, true, "Wednesday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 68, true, "Friday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 70, true, "Friday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 89, true, "Saturday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 88, true, "Saturday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 87, true, "Saturday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 86, true, "Saturday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 85, true, "Saturday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 84, true, "Saturday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 83, true, "Saturday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 82, true, "Saturday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 81, true, "Saturday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 80, true, "Saturday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 79, true, "Saturday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 78, true, "Friday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 77, true, "Friday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 76, true, "Friday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 75, true, "Friday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 74, true, "Friday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 73, true, "Friday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 72, true, "Friday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 71, true, "Friday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 69, true, "Friday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 90, true, "Saturday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 46, true, "Wednesday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 44, true, "Wednesday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 20, true, "Monday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 19, true, "Monday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 18, true, "Monday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 17, true, "Monday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 16, true, "Monday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 15, true, "Monday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 14, true, "Monday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 13, true, "Sunday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 12, true, "Sunday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 11, true, "Sunday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 10, true, "Sunday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 9, true, "Sunday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 8, true, "Sunday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 7, true, "Sunday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 6, true, "Sunday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 5, true, "Sunday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 4, true, "Sunday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 3, true, "Sunday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 2, true, "Sunday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 21, true, "Monday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 45, true, "Wednesday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 22, true, "Monday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 24, true, "Monday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 43, true, "Wednesday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 42, true, "Wednesday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 41, true, "Wednesday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 40, true, "Wednesday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 39, true, "Tuesday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 38, true, "Tuesday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 37, true, "Tuesday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 36, true, "Tuesday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 35, true, "Tuesday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 34, true, "Tuesday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 33, true, "Tuesday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 32, true, "Tuesday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 31, true, "Tuesday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 30, true, "Tuesday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 29, true, "Tuesday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 28, true, "Tuesday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 27, true, "Tuesday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 26, true, "Monday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 25, true, "Monday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 23, true, "Monday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 91, true, "Saturday", "8:00PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appts");

            migrationBuilder.DropTable(
                name: "ApptTimes");
        }
    }
}
