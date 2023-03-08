using Microsoft.AspNetCore.Mvc;
using System;
using Tool.Server.Models;
using Tool.Server.Services;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



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
        // GET: api/<QuestionController>
        [HttpGet]
        public async Task<List<AddQuestion>> GetAll()



        {
            Console.WriteLine("hlloodfa");
            return await _questionService.getAllQuestionCategory();
        }



        [HttpGet("{QuizesQuestionId}")]
        public async Task<AddQuestion> Get(int QuizesQuestionId)
        {
            return await _questionService.GetQuestion(QuizesQuestionId);
        }



        // POST api/<QuestionController>
        [HttpPost]
        public async Task<bool> Post([FromBody] AddQuestion question)
        {
            Console.WriteLine("hlelloo");
            AddQuestion newQuestion = await _questionService.addQuestionCategory(question);
            if (newQuestion != null) return true; else return false;




        }
        [HttpPut("{QuizesQuestionId}")]
        public async Task<bool> UpdateQuestion(int QuizesQuestionId, [FromBody] AddQuestion Object)
        {
            await _questionService.UpdateQuestion(QuizesQuestionId, Object); return true;
        }



        



        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}