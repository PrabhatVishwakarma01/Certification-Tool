using Microsoft.EntityFrameworkCore;
using System;
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
        public async Task<QuizModel> addQuizCategory(QuizModel quiz)
        {
            return addedQuiz = await _quiz.CreateAsync(quiz);
        }



        public async Task<List<QuizModel>> GetAllAsync()
        {
            return await _quiz.GetAllAsync();
        }

        public async Task<List<QuizModel>> getAllQuizCategory()
        {
            return await _quiz.GetAllAsync();
        }


    }
}