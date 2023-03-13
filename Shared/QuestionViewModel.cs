using System.ComponentModel.DataAnnotations;

namespace Tool.Shared
{
    public class QuestionViewModel
    {

        public int QuestionQuizId { get; set; }

        [Required(ErrorMessage = "This field Cann't be empty")]
        [Display(Name = "Question Text")]
        public string QuestionText { get; set; }

        [Required]
        [Display(Name = "Option 1")]
        public string OptionOne { get; set; }

        [Required]
        [Display(Name = "Option 2")]
        public string OptionTwo { get; set; }

        [Required]
        [Display(Name = "Option 3")]
        public string OptionThree { get; set; }
        [Required]
        [Display(Name = "Option 4")]
        public string OptionFour { get; set; }

        public bool Checkbox { get; set; }
    }
}