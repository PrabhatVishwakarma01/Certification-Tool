using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace Tool.Server.Models;

public class QuizQuestion
{
    [Key]
    [ForeignKey("Quiz")]
    public int QuizQuestionId { get; set; }
    public int QuizId { get; set; }
    public QuizModel Quiz { get; set; }

    public int QuestionTypeId { get; set; }
    public string QuestionText { get; set; }
    public int QuestionOrder { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public bool IsActive { get; set; }
    public byte[] QuestionMedia { get; set; }
    public string ToolTip { get; set; }


    //Navigation Properties

    public QuestionType QuestionType { get; set; }
    public ICollection<QuestionOption> QuestionOptions { get; set; }
    public ICollection<UserAnswer> UserAnswers { get; set; }
}

