﻿
using System.ComponentModel.DataAnnotations;

namespace coreFormsAndValidation.Models
{
    public class Account
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string? Username { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(15)]
        public string? Password { get; set; }
        [Range(18, 60)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Url]
        public string? Website { get; set; }
    }
}
