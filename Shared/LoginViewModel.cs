using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tool.Shared
{
    public class LoginViewModel
    {
        public int Id
        {
            get;
            set;
        }
        [Required]
        
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [RegularExpression(".*@persistent\\.com$",
    ErrorMessage = "Email must contain @persistent.com")]
        public string Email
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$",
            ErrorMessage = "Invalid pattern.")]
        public string Password
        {
            get;
            set;
        }
    }
}