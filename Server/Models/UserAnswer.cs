using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models;

public class UserAnswer
{
    [Key]
    public int UserAnswerId { get; set; }
    public int UserId { get; set; }
    public int QuizId { get; set; }
    public int Attempt { get; set; }
    public int QuestionId { get; set; }
    public int UserSelectedOption { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public string Comment { get; set; }

    //Navigation Properties
    public User User { get; set; }
    public QuizModel Quiz { get; set; }
    public QuizQuestion QuizQuestion { get; set; }
}
