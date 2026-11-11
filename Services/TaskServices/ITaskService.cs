using Taskify.Models.Enums;
using Taskify.Models;

namespace Taskify.Services.TaskServices;
// Interface for task service
public interface ITaskService
{
    // Method to get all tasks
    List<Tasks> GetAllTasks(string? title);
    // Method to get a task by its ID
    Tasks GetTaskById(int id);
// Method to create a new task
    Tasks CreateTask(Tasks task);

}
