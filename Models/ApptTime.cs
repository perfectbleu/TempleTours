using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTours.Models
{
    public class ApptTime
    {
        [Key]
        [Required]
        public int TimeId { get; set; }
        public string TimeOfAppt { get; set; }
    }
}
