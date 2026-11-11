using Taskify.Models.Enums;
namespace Taskify.Models;
public class Tasks
{
    public int Id { get; set; } = new Random().Next(1, 1000);
    public string Title { get; set; }
    public string? Description { get; set; }
    public Priority Priority { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime DueDate { get; set; } 
    public bool IsCompleted { get; set; } = false;

   
}