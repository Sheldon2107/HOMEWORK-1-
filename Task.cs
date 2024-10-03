
using System;

public class Task
{
    public string TaskName { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string taskName, string description, DateTime dueDate)
    {
        TaskName = taskName;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public void MarkComplete()
    {
        IsCompleted = true;
        Console.WriteLine($"{TaskName} is marked as completed.");
    }

    public void UpdateTask(string description, DateTime dueDate)
    {
        Description = description;
        DueDate = dueDate;
        Console.WriteLine($"{TaskName} has been updated.");
    }
}
