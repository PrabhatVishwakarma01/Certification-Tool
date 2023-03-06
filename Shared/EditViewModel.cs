using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;



namespace Tool.Shared
{
    public class EditViewModel
    {



        [Required]
        [Display(Name = "QuestionName")]
        public string QuestionName
        {
            get;
            set;
        }
        public string Option1
        {
            get;
            set;
        }
        public string Option2
        {
            get;
            set;
        }
        public string Option3
        {
            get;
            set;
        }
        public string Option4
        {
            get;
            set;

        }
    }
}