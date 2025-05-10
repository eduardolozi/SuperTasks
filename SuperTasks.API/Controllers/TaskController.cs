using Microsoft.AspNetCore.Mvc;
using SuperTasks.Application.Interfaces;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController(ITaskService taskService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Task>>> GetAll()
    {
        var tasks = await taskService.GetAll();
        return Ok(tasks);
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
    public async Task<ActionResult> Create([FromBody] Domain.Models.Task task)
    {
        try
        {
            await taskService.Create(task);
            return Ok();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
    
    [HttpDelete]
    public ActionResult Delete()
    {
        return Ok();
    }
}