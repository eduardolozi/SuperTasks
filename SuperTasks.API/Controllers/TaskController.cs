using Microsoft.AspNetCore.Mvc;
using SuperTasks.Domain.Models;
using Task = System.Threading.Tasks.Task;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Task>> GetAll()
    {
        return Oks();
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