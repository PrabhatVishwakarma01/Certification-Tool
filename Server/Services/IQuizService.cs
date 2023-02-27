using System.Threading.Tasks;
using Tool.Server.Models;


    public interface IQuizService
    {
        Task<QuizModel> addQuizCategory(QuizModel quiz);

        Task<List <QuizModel>> getAllQuizCategory();
    }

