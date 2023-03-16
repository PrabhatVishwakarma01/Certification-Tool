using System.Collections.Generic;
using System.Threading.Tasks;
using Tool.Server.Models;

namespace Tool.Server.Services
{
    public interface IQuestionService
    {
        Task<QuestionModel> AddQuestionModel(QuestionModel question);
        Task<bool> UpdateQuestionModel(int id, QuestionModel question);
        Task<bool> DeleteQuestionModel(int id);
        Task<List<QuestionModel>> GetAllQuestionModel();
        Task<QuestionModel> GetQuestionModel(int id);
        Task<QuestionModel> GetQuestionByTextAsync(string questionText);
        Task<QuestionModel> AddQuestion(QuestionModel question);
    }
}
