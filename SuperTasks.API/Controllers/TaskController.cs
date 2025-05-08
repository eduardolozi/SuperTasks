using Microsoft.AspNetCore.Mvc;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Task>> GetAll()
    {
        return Ok();
    }
    
    [HttpGet("{id}")]
    public ActionResult<Task> GetById([FromRoute] int id)
    {
        return Ok();
    }
    
    [HttpPost]
    public ActionResult Create()
    {
        return Ok();
    }
    
    [HttpDelete]
    public ActionResult Delete()
    {
        return Ok();
    }
}