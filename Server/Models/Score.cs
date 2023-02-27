using System.ComponentModel.DataAnnotations;

namespace Tool.Server.Models;

public class Score
{
    [Key]
    public int ScoreId { get; set; }
    public int QuizId { get; set; }
    public int UserId { get; set; }
    public int ObtainedScore { get; set; }

    //Navigation Properties
    public QuizModel Quiz { get; set; }
    public User User { get; set; }
}
