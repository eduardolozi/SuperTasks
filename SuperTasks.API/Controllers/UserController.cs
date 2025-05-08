using Microsoft.AspNetCore.Mvc;
using SuperTasks.Application.Interfaces;
using SuperTasks.Domain.Models;

namespace SuperTasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User user)
    {
        await userService.Create(user);
        return Ok();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetById([FromRoute] int id)
    {
        var user = await userService.GetById(id);
        return Ok(user);
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAll()
    {
        try
        {
            var users = await userService.GetAll();
            return Ok(users);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message, e);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await userService.Delete(id);
        return Ok();
    }
}