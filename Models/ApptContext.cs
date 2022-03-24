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
                new ApptModel { ApptId = 1, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "8:00AM", Available = true},
                new ApptModel { ApptId = 2, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday",  TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 3, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 4, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 5, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 6, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 7, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 8, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 9, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 10, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 11, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 12, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 13, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Sunday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 14, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 15, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 16, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 17, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 18, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 19, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 20, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 21, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 22, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 23, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 24, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 25, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 26, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Monday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 27, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 28, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 29, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 30, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 31, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 32, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 33, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 34, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 35, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 36, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 37, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 38, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 39, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Tuesday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 40, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 41, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 42, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 43, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 44, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 45, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 46, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 47, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 48, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 49, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 50, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 51, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 52, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Wednesday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 53, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 54, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 55, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 56, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 57, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 58, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 59, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 60, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 61, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 62, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 63, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 64, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 65, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Thursday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 66, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 67, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 68, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 69, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 70, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 71, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 72, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 73, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 74, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 75, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 76, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 77, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 78, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Friday", TimeOfAppt = "8:00PM", Available = true },
                new ApptModel { ApptId = 79, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "8:00AM", Available = true },
                new ApptModel { ApptId = 80, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "9:00AM", Available = true },
                new ApptModel { ApptId = 81, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "10:00AM", Available = true },
                new ApptModel { ApptId = 82, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "11:00AM", Available = true },
                new ApptModel { ApptId = 83, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "12:00PM", Available = true },
                new ApptModel { ApptId = 84, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "1:00PM", Available = true },
                new ApptModel { ApptId = 85, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "2:00PM", Available = true },
                new ApptModel { ApptId = 86, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "3:00PM", Available = true },
                new ApptModel { ApptId = 87, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "4:00PM", Available = true },
                new ApptModel { ApptId = 88, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "5:00PM", Available = true },
                new ApptModel { ApptId = 89, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "6:00PM", Available = true },
                new ApptModel { ApptId = 90, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "7:00PM", Available = true },
                new ApptModel { ApptId = 91, GroupName = null, GroupSize = 0, Email = null, DayOfAppt = "Saturday", TimeOfAppt = "8:00PM", Available = true }
                );
        }
    }
}