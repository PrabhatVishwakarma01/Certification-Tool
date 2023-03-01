using Tool.Server.Models;

namespace Tool.Server.Services
{
    public interface IQuestionService
    {
        Task<AddQuestion> addQuestionCategory(AddQuestion addQuestion);
  
        Task<List<AddQuestion>> getAllQuestionCategory();



    }
}
