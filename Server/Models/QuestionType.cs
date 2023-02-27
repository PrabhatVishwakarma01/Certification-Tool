using System.ComponentModel.DataAnnotations;

namespace Tool.Server.Models;

public class QuestionType
{
    [Key]
    public int QuestionTypeId { get; set; }
    public int Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int UpdatedBy { get; set; }
    public int CreatedBy { get; set; }

    //Navigation properties

    public QuizQuestion QuizQuestion { get; set; }


}
