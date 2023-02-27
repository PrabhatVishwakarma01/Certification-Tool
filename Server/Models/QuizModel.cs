using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool.Server.Models;

public class QuizModel
{
    [Key]
    public int QuizId { get; set; }
    public string QuizTitle { get; set; }
    public int MaxScore { get; set; }
    public int PassingScore { get; set; }
    public string QuizLevel { get; set; }
    public double Timer { get; set; }
    public int PublishedBy { get; set; }
    public DateTime PublishedAt { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int DeletedBy { get; set; }

    //Navigation Properties
    
    public ICollection<QuizQuestion> QuizQuestions { get; set; }
    public ICollection<QuestionOption> QuestionOptions { get; set; }
    public ICollection<QuizReport> QuizReports { get; set; }
    public ICollection<Score> Scores { get; set; }





}
