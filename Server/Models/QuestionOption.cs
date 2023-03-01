using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models;

public class QuestionOption
{
    [Key]
    [ForeignKey("Quiz")]
    public int QuizOptionId { get; set; }
    public int QuizId { get; set; }
    public int QuestionId { get; set; }
    public bool IsCorrect { get; set; }
    public string OptionText { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public string Comments { get; set; }

    //Navigation properties
    public QuizQuestion QuizQuestion { get; set; }
    public QuizModel Quiz { get; set; }

    
    public string QuestionName { get; set; }
    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string Option3 { get; set; }
    public string Option4 { get; set; }


}
