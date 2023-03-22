using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Tool.Server.Models;

namespace Tool.Server.Services 
{
    public class QuizService : IQuizService 
   {
        private readonly IRepository<QuizModel> _quiz;
        private QuizModel addedQuiz;
        private readonly AppDbContext _context;


        public QuizService(AppDbContext context, IRepository<QuizModel> quiz)
        {
            _context = context;
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

        public async Task<QuizModel> GetQuizByTitleAsync(string quizTitle) 
        {
            return await _context.Quizs.FirstOrDefaultAsync(q => q.QuizTitle == quizTitle);
        }

        public Task<bool> UpdateQuizCategory(int id, QuizModel quiz) 
        {
            throw new NotImplementedException();
        }

        public Task<QuizModel> quizById()
        {
            throw new NotImplementedException();
        }
    }
}