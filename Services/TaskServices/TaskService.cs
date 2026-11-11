using Taskify.Models;

namespace Taskify.Services.TaskServices;
// Implementation of the task service
public class TaskService : ITaskService
{
    private List<Tasks> tasks = new List<Tasks>()
    {
        new Tasks { Id = 1, Title = "Task 1", Description = "Description for Task 1", Priority = Models.Enums.Priority.High, DueDate = DateTime.Now.AddDays(7) },
        new Tasks { Id = 2, Title = "Task 2", Description = "Description for Task 2", Priority = Models.Enums.Priority.Medium, DueDate = DateTime.Now.AddDays(14) },
        new Tasks { Id = 3, Title = "Task 3", Description = "Description for Task 3", Priority = Models.Enums.Priority.Low, DueDate = DateTime.Now.AddDays(21) },
        new Tasks { Id = 4, Title = "Task 4", Description = "Description for Task 4", Priority = Models.Enums.Priority.High, DueDate = DateTime.Now.AddDays(28) },
        new Tasks { Id = 5, Title = "Task 5", Description = "Description for Task 5", Priority = Models.Enums.Priority.Medium, DueDate = DateTime.Now.AddDays(35) },
    };

// Method to get all tasks
    public List<Tasks> GetAllTasks(string? title)
    {
        return tasks;
    }
//
    public Tasks GetTaskById(int id)
    {
        return tasks.Where(t => t.Id == id).FirstOrDefault();
    }
    public Tasks CreateTask(Tasks task)
    {
        tasks.Add(task);
        return task;
    }
}