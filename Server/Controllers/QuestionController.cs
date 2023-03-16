using Tool.Server.Models;
using Tool.Server.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tool.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        
        [HttpGet]
        public async Task<List<QuestionModel>> GetAll()
        {
            return await _questionService.GetAllQuestionModel();
        }

        [HttpGet("{id}")]
        public async Task<QuestionModel> Get(int id)
        {
            return await _questionService.GetQuestionModel(id);
        }

        [HttpPost]
        public async Task<QuestionModel> AddQuestionModel([FromBody] QuestionModel question)
        {
           return await _questionService.AddQuestionModel(question);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteQuestionModel(int id)
        {
            await _questionService.DeleteQuestionModel(id); return true;
        }

        [HttpPut("{id}")]
        public async Task<bool> UpdateQuestionModel(int id, [FromBody] QuestionModel Object)
        {
            await _questionService.UpdateQuestionModel(id, Object); return true;
        }
// POST api/<QuestionController>
        public async Task<bool> Post([FromBody] QuestionModel question)
        {
            Console.WriteLine("hlelloo");

            // Check if the question already exists in the database
            QuestionModel existingQuestion = await _questionService.GetQuestionByTextAsync(question.QuestionText);
            if (existingQuestion != null)
            {
                // Quiz already exists, return false to indicate failure
                return false;
            }

            // Quiz doesn't exist, add it to the database
            QuestionModel newQuestion = await _questionService.AddQuestion(question);
            if (newQuestion != null)
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
