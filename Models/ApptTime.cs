using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTours.Models
{
    public class ApptTime
    {
        [Key]
        [Required]
        public int TimeId { get; set; }
        public string DayOfAppt { get; set; }
        public string TimeOfAppt { get; set; }

        public bool Available { get; set; } = true;
    }
}
