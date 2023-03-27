using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using Tool.Server.Models;
using Tool.Server.Services;

namespace Tool.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        public ScoreController(IScoreService scoreService) 
        {
            _scoreService = scoreService;
        }

        [HttpGet]
        public async Task<List<Score>> GetAll()
        {
            Console.WriteLine("hlloodfa");
            return await _scoreService.GetAllScore();
        }

        [HttpGet("{id}")]
        public async Task<Score> Get(int id)
        {
            return await _scoreService.GetScore(id);
        }

        public async Task<bool> Post([FromBody] Score score)
        {
            Console.WriteLine("hlelloo");

            // Check if the score already exists in the database
            Score existingScore = await _scoreService.GetScoreAsync(score.ObtainedScore);
            if (existingScore != null)
            {
                // Score already exists, return false to indicate failure
                return false;
            }

            // Score doesn't exist, add it to the database
            Score newScore = await _scoreService.AddScore(score);
            if (newScore != null)
            {
                // Quiz added successfully, return true to indicate success
                return true;
            }
            else
            {
                // Quiz could not be added, return false to indicate failure
                return false;
            }
        }


    }
}
