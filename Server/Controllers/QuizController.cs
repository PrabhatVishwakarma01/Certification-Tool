using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Tool.Server.Model;

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
        public async Task<List<Quiz>> GetAll() 
        {
            Console.WriteLine("hlloodfa");
            return await _quizService.GetAllQuizCategory();
        }

        // GET api/<QuizController>/5
        [HttpGet("{id}")]
        public async Task<Quiz> Get(int id) 
        {
            return await _quizService.GetQuizCategory(id);
        }

        // POST api/<QuizController>
        public async Task<bool> Post([FromBody] Quiz quiz) 
            {
            Console.WriteLine("hlelloo");

            // Check if the quiz already exists in the database
            Quiz existingQuiz = await _quizService.GetQuizByTitleAsync(quiz.QuizTitle);
            if (existingQuiz != null) {
                // Quiz already exists, return false to indicate failure
                return false;
            }

            // Quiz doesn't exist, add it to the database
            Quiz newQuiz = await _quizService.AddQuizCategory(quiz);
            if (newQuiz != null) {
                // Quiz added successfully, return true to indicate success
                return true;
            }
            else {
                // Quiz could not be added, return false to indicate failure
                return false;
            }
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