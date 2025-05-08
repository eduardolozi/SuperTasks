using Microsoft.AspNetCore.Mvc;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok();
    }
}