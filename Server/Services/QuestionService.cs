using Microsoft.EntityFrameworkCore;
using System;
using Tool.Server.Models;



namespace Tool.Server.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<AddQuestion> _addQuestion;
        private AddQuestion addedQuestion;




        public QuestionService(IRepository<AddQuestion> addQuestion)
        {
            _addQuestion = addQuestion;
        }
        public async Task<AddQuestion> addQuestionCategory(AddQuestion addQuestion)
        {
            return addedQuestion = await _addQuestion.CreateAsync(addQuestion);
        }
        public async Task<List<AddQuestion>> GetAllAsync()
        {
            return await _addQuestion.GetAllAsync();
        }
        public async Task<List<AddQuestion>> getAllQuestionCategory()
        {
            return await _addQuestion.GetAllAsync();
        }


        public async Task<bool> UpdateQuestion(int QuizesQuestionId, AddQuestion addQuestion)
        {
            var data = await _addQuestion.GetByIdAsync(QuizesQuestionId);

            if (data != null)
            {
                data.QuestionName = addQuestion.QuestionName;
                data.Option1 = addQuestion.Option1;
                data.Option2 = addQuestion.Option2;
                data.Option3 = addQuestion.Option3;
                data.Option4 = addQuestion.Option4;

                await _addQuestion.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
        public async Task<AddQuestion> GetQuestion(int QuizesQuestionId)
        {
            return await _addQuestion.GetByIdAsync(QuizesQuestionId);
        }
    }
}