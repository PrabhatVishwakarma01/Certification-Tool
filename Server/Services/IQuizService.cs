using System.Threading.Tasks;
using Tool.Server.Models;


public interface IQuizService 
{
    Task<QuizModel> AddQuizCategory(QuizModel quiz);

    Task<List<QuizModel>> GetAllQuizCategory();
    Task<QuizModel> GetQuizCategory(int id);

    Task<bool> UpdateQuizCategory(int id, QuizModel quiz);

    Task<bool> DeleteQuizCategory(int id);
    Task<QuizModel> GetQuizByTitleAsync(string quizTitle);


}