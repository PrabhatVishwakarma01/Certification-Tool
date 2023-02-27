using System.ComponentModel.DataAnnotations;

namespace Tool.Server.Models;

public class UserAnswerMapping
{
    [Key]
    public int UserAnsweringMappingId { get; set; }
    public int UserId { get; set; }
    public int Attempt { get; set; }
    public int QuestionId { get; set; }
    public int QuizOptionId { get; set; }
    public int UserSelectedOption { get; set; }
    public int Score { get; set; }

    //Navigation Properties
    public User User { get; set; }
    public QuizQuestion QuizQuestion { get; set; }
    public QuestionOption Question { get; set; }

}
