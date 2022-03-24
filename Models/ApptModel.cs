using System;
using System.ComponentModel.DataAnnotations;
using TempleTours.Models;

namespace TempleTours.Models
{
    public class ApptModel
    {
        [Key]
        [Required]
        public int ApptId { get; set; }

        public string GroupName { get; set; }

        [Range(0, 15)]
        public int GroupSize { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        //time of appointment info
        public string DayOfAppt { get; set; }
        public string TimeOfAppt { get; set; }
        public bool Available { get; set; } = true;

    }
}