using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controllers2.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Email field is required")]
        [RegularExpression(@"(?i)\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "Email isn't correct")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You haven't entered login")]
        [StringLength(10, ErrorMessage = "Login can't exceed 12 characters")]
        public string Login { get; set; }

        [Required(ErrorMessage = "You haven't entered password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password must be beetween 8 and 20 characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords isn't equal")]
        public string PasswordConfirm { get; set; }

        [MustBeTrueAtribute(ErrorMessage ="You don't agree with the TermsAccepted")]
        public bool TermsAccepted { get; set; }
    }
}