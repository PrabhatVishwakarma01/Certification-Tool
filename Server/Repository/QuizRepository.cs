using Microsoft.EntityFrameworkCore;
using System;
using Tool.Server.Models;

namespace Tool.Server.Repository
{
    public class QuizRepository : IRepository<QuizModel>
    {

        readonly AppDbContext _dbContext;
        public QuizRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<QuizModel> CreateAsync(QuizModel _object)
        {
            var obj = await _dbContext.Quizs.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public async Task UpdateAsync(QuizModel _object)
        {
            _dbContext.Quizs.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<QuizModel>> GetAllAsync()
        {
            return await _dbContext.Quizs.ToListAsync();
        }

        Task<QuizModel> IRepository<QuizModel>.GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<QuizModel>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}