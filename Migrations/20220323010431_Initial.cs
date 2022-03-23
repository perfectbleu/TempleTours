using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTours.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Appts",
                columns: table => new
                {
                    ApptId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(maxLength: 15, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false),
                    ApptTimeTimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appts", x => x.ApptId);
                    table.ForeignKey(
                        name: "FK_Appts_ApptTimes_ApptTimeTimeId",
                        column: x => x.ApptTimeTimeId,
                        principalTable: "ApptTimes",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 1, false, "Sunday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 66, false, "Friday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 65, false, "Thursday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 64, false, "Thursday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 63, false, "Thursday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 62, false, "Thursday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 61, false, "Thursday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 60, false, "Thursday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 59, false, "Thursday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 58, false, "Thursday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 57, false, "Thursday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 56, false, "Thursday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 55, false, "Thursday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 54, false, "Thursday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 53, false, "Thursday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 52, false, "Wednesday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 51, false, "Wednesday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 50, false, "Wednesday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 49, false, "Wednesday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 48, false, "Wednesday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 67, false, "Friday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 47, false, "Wednesday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 68, false, "Friday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 70, false, "Friday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 89, false, "Saturday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 88, false, "Saturday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 87, false, "Saturday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 86, false, "Saturday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 85, false, "Saturday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 84, false, "Saturday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 83, false, "Saturday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 82, false, "Saturday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 81, false, "Saturday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 80, false, "Saturday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 79, false, "Saturday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 78, false, "Friday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 77, false, "Friday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 76, false, "Friday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 75, false, "Friday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 74, false, "Friday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 73, false, "Friday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 72, false, "Friday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 71, false, "Friday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 69, false, "Friday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 90, false, "Saturday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 46, false, "Wednesday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 44, false, "Wednesday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 20, false, "Monday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 19, false, "Monday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 18, false, "Monday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 17, false, "Monday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 16, false, "Monday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 15, false, "Monday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 14, false, "Monday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 13, false, "Sunday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 12, false, "Sunday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 11, false, "Sunday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 10, false, "Sunday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 9, false, "Sunday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 8, false, "Sunday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 7, false, "Sunday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 6, false, "Sunday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 5, false, "Sunday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 4, false, "Sunday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 3, false, "Sunday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 2, false, "Sunday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 21, false, "Monday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 45, false, "Wednesday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 22, false, "Monday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 24, false, "Monday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 43, false, "Wednesday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 42, false, "Wednesday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 41, false, "Wednesday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 40, false, "Wednesday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 39, false, "Tuesday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 38, false, "Tuesday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 37, false, "Tuesday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 36, false, "Tuesday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 35, false, "Tuesday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 34, false, "Tuesday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 33, false, "Tuesday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 32, false, "Tuesday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 31, false, "Tuesday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 30, false, "Tuesday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 29, false, "Tuesday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 28, false, "Tuesday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 27, false, "Tuesday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 26, false, "Monday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 25, false, "Monday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 23, false, "Monday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "Available", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 91, false, "Saturday", "8:00PM" });

            migrationBuilder.CreateIndex(
                name: "IX_Appts_ApptTimeTimeId",
                table: "Appts",
                column: "ApptTimeTimeId");
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
