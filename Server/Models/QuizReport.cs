using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models;

public class QuizReport
{
    [Key]
    [ForeignKey("Quiz")]
    public int QuizReportId { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int QuizId { get; set; }
    public int ObtainedScore { get; set; }
    public int PassingScore { get; set; }
    public string Result { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public string Comment { get; set; }
    public int Attempt { get; set; }

    //Navigation Properties

    public QuizModel Quiz { get; set; }

}
