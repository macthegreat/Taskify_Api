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
// POST: api/V1/Task
    [HttpPost]
    public IActionResult CreateTask([FromBody] Tasks task)
    {
        var createdTask = _taskService.CreateTask(task);
        return CreatedAtAction(nameof(GetTaskById), new { id = createdTask.Id }, createdTask);

    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, [FromBody] Tasks task)
    {
        var updatedTask = _taskService.UpdateTask(id, task);
        if (updatedTask == null)
        {
            return NotFound();
        }
        return Ok(updatedTask);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        var isDeleted = _taskService.DeleteTask(id);
        if (!isDeleted)
        {
            return NotFound();  
        }
        return NoContent();
    }
}