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

        [Required]
        public string GroupName { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Maximum Group Size is 15")]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        // set up foreign key relationship
        public int TimeId { get; set; }
        public ApptTime ApptTime { get; set; }

        public bool Available { get; set; }
    }
}