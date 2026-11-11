using Microsoft.AspNetCore.Mvc;
using Taskify.Models;
using Taskify.Services.TaskServices;

namespace Taskify.Controllers;
[ApiController]
[Route("api/V1/[controller]")]
public class TaskController : ControllerBase
{
    // Dependency injection for the task service
    private readonly ITaskService _taskService;


    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }
  
// GET: api/V1/Task
    [HttpGet]
    public IActionResult GetAllTasks([FromQuery] string? title )
    {
        var result = _taskService.GetAllTasks(title);
        return Ok(result);
    }

// GET: api/V1/Task/{id}
    [HttpGet("{id}")]
    public IActionResult GetTaskById(int id)
    {
        var result = _taskService.GetTaskById(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

}