using Tool.Server.Models;



namespace Tool.Server.Services
{
    public interface IQuestionService
    {
        Task<AddQuestion> addQuestionCategory(AddQuestion addQuestion);

        Task<List<AddQuestion>> getAllQuestionCategory();

        Task<bool> UpdateQuestion(int id, AddQuestion addQuestion);
        Task<AddQuestion> GetQuestion(int QuizesQuestionId);



    }
}