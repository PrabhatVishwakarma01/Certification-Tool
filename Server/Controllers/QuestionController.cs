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
    }
}
