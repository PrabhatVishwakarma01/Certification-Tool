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



    }
}