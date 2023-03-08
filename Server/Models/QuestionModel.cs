using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models
{
    public class QuestionModel
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int QuestionQuizId { get; set; }
        
        [Required] 
        public string QuestionText { get; set; }
        
        [Required] 
        public string OptionOne { get; set; }
        
        [Required] 
        public string OptionTwo { get;set; }
        
        [Required] 
        public string OptionThree { get; set; }

        [Required]
        public string OptionFour { get; set; }
    }
}
