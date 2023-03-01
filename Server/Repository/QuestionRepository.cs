using Microsoft.EntityFrameworkCore;
using System;
using Tool.Server.Models;


namespace Tool.Server.Repository
{
    public class QuestionRepository: IRepository<AddQuestion>
    {
        readonly AppDbContext _dbContext;
        public QuestionRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<AddQuestion> CreateAsync(AddQuestion _object)
        {
            var obj = await _dbContext.AddQuestions.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public async Task UpdateAsync(AddQuestion _object)
        {
            _dbContext.AddQuestions.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<AddQuestion>> GetAllAsync()
        {
            return await _dbContext.AddQuestions.ToListAsync();
        }

        Task<AddQuestion> IRepository<AddQuestion>.GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<AddQuestion>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

    }
}
