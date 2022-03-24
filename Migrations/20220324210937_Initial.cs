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
                    GroupName = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    DayOfAppt = table.Column<string>(nullable: true),
                    TimeOfAppt = table.Column<string>(nullable: true),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appts", x => x.ApptId);
                });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 1, true, "Sunday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 66, true, "Friday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 65, true, "Thursday", null, null, 0, null, "8:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 64, true, "Thursday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 63, true, "Thursday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 62, true, "Thursday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 61, true, "Thursday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 60, true, "Thursday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 59, true, "Thursday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 58, true, "Thursday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 57, true, "Thursday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 56, true, "Thursday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 55, true, "Thursday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 54, true, "Thursday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 53, true, "Thursday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 52, true, "Wednesday", null, null, 0, null, "8:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 51, true, "Wednesday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 50, true, "Wednesday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 49, true, "Wednesday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 48, true, "Wednesday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 67, true, "Friday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 47, true, "Wednesday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 68, true, "Friday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 70, true, "Friday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 89, true, "Saturday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 88, true, "Saturday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 87, true, "Saturday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 86, true, "Saturday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 85, true, "Saturday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 84, true, "Saturday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 83, true, "Saturday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 82, true, "Saturday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 81, true, "Saturday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 80, true, "Saturday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 79, true, "Saturday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 78, true, "Friday", null, null, 0, null, "8:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 77, true, "Friday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 76, true, "Friday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 75, true, "Friday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 74, true, "Friday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 73, true, "Friday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 72, true, "Friday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 71, true, "Friday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 69, true, "Friday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 90, true, "Saturday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 46, true, "Wednesday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 44, true, "Wednesday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 20, true, "Monday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 19, true, "Monday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 18, true, "Monday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 17, true, "Monday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 16, true, "Monday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 15, true, "Monday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 14, true, "Monday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 13, true, "Sunday", null, null, 0, null, "8:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 12, true, "Sunday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 11, true, "Sunday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 10, true, "Sunday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 9, true, "Sunday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 8, true, "Sunday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 7, true, "Sunday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 6, true, "Sunday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 5, true, "Sunday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 4, true, "Sunday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 3, true, "Sunday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 2, true, "Sunday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 21, true, "Monday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 45, true, "Wednesday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 22, true, "Monday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 24, true, "Monday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 43, true, "Wednesday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 42, true, "Wednesday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 41, true, "Wednesday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 40, true, "Wednesday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 39, true, "Tuesday", null, null, 0, null, "8:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 38, true, "Tuesday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 37, true, "Tuesday", null, null, 0, null, "6:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 36, true, "Tuesday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 35, true, "Tuesday", null, null, 0, null, "4:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 34, true, "Tuesday", null, null, 0, null, "3:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 33, true, "Tuesday", null, null, 0, null, "2:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 32, true, "Tuesday", null, null, 0, null, "1:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 31, true, "Tuesday", null, null, 0, null, "12:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 30, true, "Tuesday", null, null, 0, null, "11:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 29, true, "Tuesday", null, null, 0, null, "10:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 28, true, "Tuesday", null, null, 0, null, "9:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 27, true, "Tuesday", null, null, 0, null, "8:00AM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 26, true, "Monday", null, null, 0, null, "8:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 25, true, "Monday", null, null, 0, null, "7:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 23, true, "Monday", null, null, 0, null, "5:00PM" });

            migrationBuilder.InsertData(
                table: "Appts",
                columns: new[] { "ApptId", "Available", "DayOfAppt", "Email", "GroupName", "GroupSize", "PhoneNumber", "TimeOfAppt" },
                values: new object[] { 91, true, "Saturday", null, null, 0, null, "8:00PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appts");
        }
    }
}
