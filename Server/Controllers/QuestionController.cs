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

        // GET api/<QuizController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuestionController>
        [HttpPost]
        public async Task<bool> Post([FromBody]AddQuestion question)
        {
            Console.WriteLine("hlelloo");
            AddQuestion newQuestion = await _questionService.addQuestionCategory(question);
            if (newQuestion != null) return true; else return false;


        }

        // PUT api/<QuestionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuestionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
