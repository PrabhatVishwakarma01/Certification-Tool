using Microsoft.AspNetCore.Mvc;
using Tool.Server.Model;
using Tool.Server.Services;

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
    public async Task<List<Question>> GetAll()
    {
        return await _questionService.GetAllQuestion();
    }

    [HttpGet("{id}")]
    public async Task<Question> Get(int id)
    {
        return await _questionService.GetQuestion(id);
    }

    [HttpPost]
    public async Task<ActionResult<Question>> AddQuestion([FromBody] Question question)
    {
        var newQuestion = await _questionService.AddQuestion(question);

        if (newQuestion == null)
        {
            return BadRequest("Failed to add question");
        }

        return Ok(newQuestion);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> DeleteQuestion(int id)
    {
        await _questionService.DeleteQuestion(id);
        return Ok(true);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<bool>> UpdateQuestion(int id, [FromBody] Question Object)
    {
        await _questionService.UpdateQuestion(id, Object);
        return Ok(true);
    }
}
