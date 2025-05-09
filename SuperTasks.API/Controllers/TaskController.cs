using Microsoft.AspNetCore.Mvc;
using SuperTasks.Application.Interfaces;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController(ITaskService taskService) : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Task>> GetAll()
    {
        return Ok();
    }

    [HttpPatch("{id}")]
    public ActionResult Update([FromRoute] int id, [FromBody] Task task)
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