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
        public DbSet<ApptTime> ApptTimes { get; set; }

        // seed the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApptTime>().HasData(
                new ApptTime { TimeId = 1, DayOfAppt = "Sunday", TimeOfAppt = "8:00AM"},
                new ApptTime { TimeId = 2, DayOfAppt = "Sunday",  TimeOfAppt = "9:00AM"},
                new ApptTime { TimeId = 3, DayOfAppt = "Sunday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 4, DayOfAppt = "Sunday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 5, DayOfAppt = "Sunday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 6, DayOfAppt = "Sunday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 7, DayOfAppt = "Sunday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 8, DayOfAppt = "Sunday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 9, DayOfAppt = "Sunday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 10, DayOfAppt = "Sunday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 11, DayOfAppt = "Sunday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 12, DayOfAppt = "Sunday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 13, DayOfAppt = "Sunday", TimeOfAppt = "8:00PM" },
                new ApptTime { TimeId = 14, DayOfAppt = "Monday", TimeOfAppt = "8:00AM" },
                new ApptTime { TimeId = 15, DayOfAppt = "Monday", TimeOfAppt = "9:00AM" },
                new ApptTime { TimeId = 16, DayOfAppt = "Monday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 17, DayOfAppt = "Monday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 18, DayOfAppt = "Monday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 19, DayOfAppt = "Monday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 20, DayOfAppt = "Monday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 21, DayOfAppt = "Monday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 22, DayOfAppt = "Monday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 23, DayOfAppt = "Monday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 24, DayOfAppt = "Monday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 25, DayOfAppt = "Monday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 26, DayOfAppt = "Monday", TimeOfAppt = "8:00PM" },
                new ApptTime { TimeId = 27, DayOfAppt = "Tuesday", TimeOfAppt = "8:00AM" },
                new ApptTime { TimeId = 28, DayOfAppt = "Tuesday", TimeOfAppt = "9:00AM" },
                new ApptTime { TimeId = 29, DayOfAppt = "Tuesday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 30, DayOfAppt = "Tuesday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 31, DayOfAppt = "Tuesday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 32, DayOfAppt = "Tuesday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 33, DayOfAppt = "Tuesday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 34, DayOfAppt = "Tuesday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 35, DayOfAppt = "Tuesday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 36, DayOfAppt = "Tuesday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 37, DayOfAppt = "Tuesday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 38, DayOfAppt = "Tuesday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 39, DayOfAppt = "Tuesday", TimeOfAppt = "8:00PM" },
                new ApptTime { TimeId = 40, DayOfAppt = "Wednesday", TimeOfAppt = "8:00AM" },
                new ApptTime { TimeId = 41, DayOfAppt = "Wednesday", TimeOfAppt = "9:00AM" },
                new ApptTime { TimeId = 42, DayOfAppt = "Wednesday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 43, DayOfAppt = "Wednesday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 44, DayOfAppt = "Wednesday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 45, DayOfAppt = "Wednesday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 46, DayOfAppt = "Wednesday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 47, DayOfAppt = "Wednesday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 48, DayOfAppt = "Wednesday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 49, DayOfAppt = "Wednesday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 50, DayOfAppt = "Wednesday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 51, DayOfAppt = "Wednesday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 52, DayOfAppt = "Wednesday", TimeOfAppt = "8:00PM" },
                new ApptTime { TimeId = 53, DayOfAppt = "Thursday", TimeOfAppt = "8:00AM" },
                new ApptTime { TimeId = 54, DayOfAppt = "Thursday", TimeOfAppt = "9:00AM" },
                new ApptTime { TimeId = 55, DayOfAppt = "Thursday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 56, DayOfAppt = "Thursday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 57, DayOfAppt = "Thursday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 58, DayOfAppt = "Thursday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 59, DayOfAppt = "Thursday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 60, DayOfAppt = "Thursday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 61, DayOfAppt = "Thursday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 62, DayOfAppt = "Thursday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 63, DayOfAppt = "Thursday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 64, DayOfAppt = "Thursday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 65, DayOfAppt = "Thursday", TimeOfAppt = "8:00PM" },
                new ApptTime { TimeId = 66, DayOfAppt = "Friday", TimeOfAppt = "8:00AM" },
                new ApptTime { TimeId = 67, DayOfAppt = "Friday", TimeOfAppt = "9:00AM" },
                new ApptTime { TimeId = 68, DayOfAppt = "Friday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 69, DayOfAppt = "Friday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 70, DayOfAppt = "Friday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 71, DayOfAppt = "Friday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 72, DayOfAppt = "Friday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 73, DayOfAppt = "Friday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 74, DayOfAppt = "Friday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 75, DayOfAppt = "Friday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 76, DayOfAppt = "Friday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 77, DayOfAppt = "Friday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 78, DayOfAppt = "Friday", TimeOfAppt = "8:00PM" },
                new ApptTime { TimeId = 79, DayOfAppt = "Saturday", TimeOfAppt = "8:00AM" },
                new ApptTime { TimeId = 80, DayOfAppt = "Saturday", TimeOfAppt = "9:00AM" },
                new ApptTime { TimeId = 81, DayOfAppt = "Saturday", TimeOfAppt = "10:00AM" },
                new ApptTime { TimeId = 82, DayOfAppt = "Saturday", TimeOfAppt = "11:00AM" },
                new ApptTime { TimeId = 83, DayOfAppt = "Saturday", TimeOfAppt = "12:00PM" },
                new ApptTime { TimeId = 84, DayOfAppt = "Saturday", TimeOfAppt = "1:00PM" },
                new ApptTime { TimeId = 85, DayOfAppt = "Saturday", TimeOfAppt = "2:00PM" },
                new ApptTime { TimeId = 86, DayOfAppt = "Saturday", TimeOfAppt = "3:00PM" },
                new ApptTime { TimeId = 87, DayOfAppt = "Saturday", TimeOfAppt = "4:00PM" },
                new ApptTime { TimeId = 88, DayOfAppt = "Saturday", TimeOfAppt = "5:00PM" },
                new ApptTime { TimeId = 89, DayOfAppt = "Saturday", TimeOfAppt = "6:00PM" },
                new ApptTime { TimeId = 90, DayOfAppt = "Saturday", TimeOfAppt = "7:00PM" },
                new ApptTime { TimeId = 91, DayOfAppt = "Saturday", TimeOfAppt = "8:00PM" }
                );
        }
    }
}