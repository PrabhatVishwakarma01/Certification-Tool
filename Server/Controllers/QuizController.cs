using Microsoft.AspNetCore.Mvc;
using System;
using Tool.Server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tool.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {

        private readonly IQuizService _quizService;
        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }
        // GET: api/<QuizController>
        [HttpGet]
        public async Task<List<QuizModel>> GetAll()

        {
            Console.WriteLine("hlloodfa");
            return await _quizService.getAllQuizCategory();
        }

        // GET api/<QuizController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuizController>
        [HttpPost]
        public async Task<bool> Post([FromBody] QuizModel quiz)
        {
            Console.WriteLine("hlelloo");
            QuizModel newQuiz = await _quizService.addQuizCategory(quiz);
            if (newQuiz != null) return true; else return false;
            

        }

        // PUT api/<QuizController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuizController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
