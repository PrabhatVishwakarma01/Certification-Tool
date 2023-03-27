using Tool.Server.Models;

namespace Tool.Server.Services
{
    public interface IScoreService
    {
        Task<Score> AddScore(Score score);
        Task<Score> GetAllScore();
        Task<Score> GetScore(int id);
        Task<Score> GetScoreAsync(int ScoreObtained);
    }
}
