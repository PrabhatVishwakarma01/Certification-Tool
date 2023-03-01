using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models
{
    public class AddQuestion
    {
        [ Key ]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuizesQuestionId { get; set; }
        public string QuestionName { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }

        public ICollection<User> Users { get; set; }
       
       
    }
}
