using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



    public class AddQuizCategoryViewModel
    {
        public int QuizId
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "QuizTitle")]
        public string QuizTitle
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Timer")]
        public double Timer
        {
            get;
            set;
        }

        
    }
