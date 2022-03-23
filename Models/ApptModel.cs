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
        [Range(0, 15)]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

    }
}