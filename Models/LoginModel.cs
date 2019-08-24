using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Controllers2.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "You haven't entered login")]
        [StringLength(10, ErrorMessage = "Login can't exceed 12 characters")]

        public string Login { get; set; }

        [Required(ErrorMessage = "You haven't entered password")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password must be beetween 8 and 20 characters")]
        [Compare("Login", ErrorMessage = "")]

        public string Password { get; set; }
    }
}