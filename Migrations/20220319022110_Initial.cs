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
                    TimeOfAppt = table.Column<string>(nullable: true)
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
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 1, "Sunday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 66, "Friday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 65, "Thursday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 64, "Thursday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 63, "Thursday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 62, "Thursday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 61, "Thursday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 60, "Thursday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 59, "Thursday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 58, "Thursday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 57, "Thursday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 56, "Thursday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 55, "Thursday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 54, "Thursday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 53, "Thursday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 52, "Wednesday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 51, "Wednesday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 50, "Wednesday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 49, "Wednesday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 48, "Wednesday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 67, "Friday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 47, "Wednesday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 68, "Friday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 70, "Friday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 89, "Saturday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 88, "Saturday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 87, "Saturday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 86, "Saturday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 85, "Saturday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 84, "Saturday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 83, "Saturday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 82, "Saturday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 81, "Saturday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 80, "Saturday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 79, "Saturday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 78, "Friday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 77, "Friday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 76, "Friday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 75, "Friday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 74, "Friday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 73, "Friday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 72, "Friday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 71, "Friday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 69, "Friday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 90, "Saturday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 46, "Wednesday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 44, "Wednesday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 20, "Monday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 19, "Monday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 18, "Monday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 17, "Monday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 16, "Monday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 15, "Monday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 14, "Monday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 13, "Sunday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 12, "Sunday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 11, "Sunday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 10, "Sunday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 9, "Sunday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 8, "Sunday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 7, "Sunday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 6, "Sunday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 5, "Sunday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 4, "Sunday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 3, "Sunday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 2, "Sunday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 21, "Monday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 45, "Wednesday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 22, "Monday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 24, "Monday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 43, "Wednesday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 42, "Wednesday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 41, "Wednesday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 40, "Wednesday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 39, "Tuesday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 38, "Tuesday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 37, "Tuesday", "6:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 36, "Tuesday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 35, "Tuesday", "4:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 34, "Tuesday", "3:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 33, "Tuesday", "2:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 32, "Tuesday", "1:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 31, "Tuesday", "12:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 30, "Tuesday", "11:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 29, "Tuesday", "10:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 28, "Tuesday", "9:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 27, "Tuesday", "8:00AM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 26, "Monday", "8:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 25, "Monday", "7:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 23, "Monday", "5:00PM" });

            migrationBuilder.InsertData(
                table: "ApptTimes",
                columns: new[] { "TimeId", "DayOfAppt", "TimeOfAppt" },
                values: new object[] { 91, "Saturday", "8:00PM" });

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
