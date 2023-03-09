using Tool.Server.Models;

namespace Tool.Server.Services
{
    public class QuizService : IQuizService
    {
        private readonly IRepository<QuizModel> _quiz;
        private QuizModel addedQuiz;


        public QuizService(IRepository<QuizModel> quiz)
        {
            _quiz = quiz;
        }
        public async Task<QuizModel> AddQuizCategory(QuizModel quiz)
        {
            return addedQuiz = await _quiz.CreateAsync(quiz);
        }

        public async Task<List<QuizModel>> GetAllAsync()
        {
            return await _quiz.GetAllAsync();
        }

        public async Task<List<QuizModel>> GetAllQuizCategory()
        {
            return await _quiz.GetAllAsync();
        }

        public async Task<bool> DeleteQuizCategory(int id)
        {
            await _quiz.DeleteAsync(id);
            return true;
        }

        public async Task<QuizModel> GetQuizCategory(int id)
        {
            return await _quiz.GetByIdAsync(id);
        }

        Task<bool> IQuizService.UpdateQuizCategory(int id, QuizModel quiz)
        {
            throw new NotImplementedException();
        }
    }
}