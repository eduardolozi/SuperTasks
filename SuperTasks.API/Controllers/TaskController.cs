using Microsoft.AspNetCore.Mvc;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult GetAll()
    {
        return Ok();
    }
    
    [HttpPost]
    public ActionResult Create()
    {
        return Ok();
    }
}