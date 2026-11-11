using Taskify.Models.Enums;
using Taskify.Models;

namespace Taskify.Services.TaskServices;
// Interface for task service
public interface ITaskService
{
    // Method to get all tasks
    List<Tasks> GetAllTasks(string? title);
    Tasks GetTaskById(int id);
}
