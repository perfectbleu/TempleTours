using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TempleTours.Models;

namespace TempleTours.Models
{
    public class ApptContext : DbContext
    {
        public ApptContext(DbContextOptions<ApptContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ApptModel> Appts { get; set; }

        // seed the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApptModel>().HasData(
                new ApptModel { ApptId = 1, DayOfAppt = "Sunday", TimeOfAppt = "8:00AM", Available = true},
                new ApptModel { ApptId = 2, DayOfAppt = "Sunday",  TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 3, DayOfAppt = "Sunday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 4, DayOfAppt = "Sunday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 5, DayOfAppt = "Sunday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 6, DayOfAppt = "Sunday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 7, DayOfAppt = "Sunday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 8, DayOfAppt = "Sunday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 9, DayOfAppt = "Sunday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 10, DayOfAppt = "Sunday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 11, DayOfAppt = "Sunday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 12, DayOfAppt = "Sunday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 13, DayOfAppt = "Sunday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 14, DayOfAppt = "Monday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 15, DayOfAppt = "Monday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 16, DayOfAppt = "Monday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 17, DayOfAppt = "Monday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 18, DayOfAppt = "Monday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 19, DayOfAppt = "Monday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 20, DayOfAppt = "Monday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 21, DayOfAppt = "Monday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 22, DayOfAppt = "Monday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 23, DayOfAppt = "Monday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 24, DayOfAppt = "Monday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 25, DayOfAppt = "Monday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 26, DayOfAppt = "Monday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 27, DayOfAppt = "Tuesday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 28, DayOfAppt = "Tuesday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 29, DayOfAppt = "Tuesday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 30, DayOfAppt = "Tuesday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 31, DayOfAppt = "Tuesday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 32, DayOfAppt = "Tuesday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 33, DayOfAppt = "Tuesday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 34, DayOfAppt = "Tuesday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 35, DayOfAppt = "Tuesday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 36, DayOfAppt = "Tuesday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 37, DayOfAppt = "Tuesday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 38, DayOfAppt = "Tuesday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 39, DayOfAppt = "Tuesday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 40, DayOfAppt = "Wednesday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 41, DayOfAppt = "Wednesday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 42, DayOfAppt = "Wednesday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 43, DayOfAppt = "Wednesday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 44, DayOfAppt = "Wednesday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 45, DayOfAppt = "Wednesday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 46, DayOfAppt = "Wednesday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 47, DayOfAppt = "Wednesday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 48, DayOfAppt = "Wednesday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 49, DayOfAppt = "Wednesday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 50, DayOfAppt = "Wednesday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 51, DayOfAppt = "Wednesday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 52, DayOfAppt = "Wednesday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 53, DayOfAppt = "Thursday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 54, DayOfAppt = "Thursday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 55, DayOfAppt = "Thursday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 56, DayOfAppt = "Thursday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 57, DayOfAppt = "Thursday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 58, DayOfAppt = "Thursday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 59, DayOfAppt = "Thursday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 60, DayOfAppt = "Thursday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 61, DayOfAppt = "Thursday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 62, DayOfAppt = "Thursday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 63, DayOfAppt = "Thursday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 64, DayOfAppt = "Thursday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 65, DayOfAppt = "Thursday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 66, DayOfAppt = "Friday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 67, DayOfAppt = "Friday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 68, DayOfAppt = "Friday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 69, DayOfAppt = "Friday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 70, DayOfAppt = "Friday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 71, DayOfAppt = "Friday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 72, DayOfAppt = "Friday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 73, DayOfAppt = "Friday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 74, DayOfAppt = "Friday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 75, DayOfAppt = "Friday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 76, DayOfAppt = "Friday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 77, DayOfAppt = "Friday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 78, DayOfAppt = "Friday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 79, DayOfAppt = "Saturday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 80, DayOfAppt = "Saturday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 81, DayOfAppt = "Saturday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 82, DayOfAppt = "Saturday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 83, DayOfAppt = "Saturday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 84, DayOfAppt = "Saturday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 85, DayOfAppt = "Saturday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 86, DayOfAppt = "Saturday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 87, DayOfAppt = "Saturday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 88, DayOfAppt = "Saturday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 89, DayOfAppt = "Saturday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 90, DayOfAppt = "Saturday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 91, DayOfAppt = "Saturday", TimeOfAppt = "8:00PM", Available = true }
                );
        }
    }
}