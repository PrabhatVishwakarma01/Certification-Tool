using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Tool.Server.Models;

namespace Tool.Server.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IRepository<Score> _score;
        private Score addedScore;
        private readonly AppDbContext _context;
        public ScoreService(AppDbContext context, IRepository<Score> score)
        {
            _context = context;
            _score = score;
        }

        public async Task<List<Score>> GetAllAsync()
        {
            return await _score.GetAllAsync();
        }
        public async Task<Score> AddScore(Score score)
        {
            return addedScore = await _score.CreateAsync(score);
        }

        public async Task<Score> GetAllScore()
        {
            return await _score.GetAllAsync();
        }
        public async Task<Score> GetScore(int id)
        {
            return await _score.GetByIdAsync(id);
        }
        public async Task<Score> GetScoreAsync(int scoreObtained)
        {
            return await _context.Scores.FirstOrDefaultAsync(q => q.ObtainedScore == scoreObtained);
        }

    }
}
