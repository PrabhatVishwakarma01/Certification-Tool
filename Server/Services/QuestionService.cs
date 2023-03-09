using Tool.Server.Models;

namespace Tool.Server.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<QuestionModel> _question;

        public QuestionService(IRepository<QuestionModel> question)
        {
            _question = question;
        }

        public async Task<QuestionModel> AddQuestionModel(QuestionModel question)
        {
            return await _question.CreateAsync(question);
        }

        public async Task<bool> UpdateQuestionModel(int id, QuestionModel question)
        {
            var data = await _question.GetByIdAsync(id);

            if (data != null)
            {
                data.QuestionText = question.QuestionText;
                data.OptionOne = question.OptionOne;
                data.OptionTwo = question.OptionTwo;
                data.OptionThree = question.OptionThree;
                data.OptionFour = question.OptionFour;

                await _question.UpdateAsync(data);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteQuestionModel(int id)
        {
            await _question.DeleteAsync(id);
            return true;
        }

        public async Task<List<QuestionModel>> GetAllQuestionModel()
        {
            return await _question.GetAllAsync();
        }

        public async Task<QuestionModel> GetQuestionModel(int id)
        {
            return await _question.GetByIdAsync(id);
        }
    }
}
