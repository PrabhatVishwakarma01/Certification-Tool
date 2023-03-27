using Tool.Server.Models;
using Microsoft.EntityFrameworkCore;


namespace Tool.Server.Repository
{
    public class ScoreRepository : IRepository<Score>
    {
        private readonly AppDbContext _dbContext;
        public ScoreRepository(AppDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Score> CreateAsync(Score _object)
        {
            var obj = await _dbContext.Scores.AddAsync(_object);
            await _dbContext.SaveChangesAsync();
            return obj.Entity;
        }

        public async Task UpdateAsync(Score _object)
        {
            _dbContext.Scores.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Score> GetAllAsync()
        {
            return await _dbContext.Scores.FindAsync();
        }

        public async Task<Score> GetByIdAsync(int id)
        {
            return await _dbContext.Scores.FirstOrDefaultAsync(x => x.ScoreId == id);
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _dbContext.Scores.FirstOrDefaultAsync(x => x.ScoreId == id);

            if (data != null)
            {
                _dbContext.Scores.Remove(data);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
