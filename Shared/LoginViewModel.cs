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
        [Display(Name = "Email")]
        public string Email
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Password")]
        public string Password
        {
            get;
            set;
        }
    }
}
