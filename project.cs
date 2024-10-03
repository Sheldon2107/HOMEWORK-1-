using System;
using System.Collections.Generic;

public class Project
{
    public string ProjectName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Task> ListOfTasks { get; set; }

    public Project(string projectName, DateTime startDate, DateTime endDate)
    {
        ProjectName = projectName;
        StartDate = startDate;
        EndDate = endDate;
        ListOfTasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        ListOfTasks.Add(task);
        Console.WriteLine($"Task {task.TaskName} added to project {ProjectName}.");
    }

    public void RemoveTask(Task task)
    {
        ListOfTasks.Remove(task);
        Console.WriteLine($"Task {task.TaskName} removed from project {ProjectName}.");
    }

    public void GetProjectSummary()
    {
        Console.WriteLine($"Project: {ProjectName}, Start Date: {StartDate}, End Date: {EndDate}");
        foreach (var task in ListOfTasks)
        {
            Console.WriteLine($"- Task: {task.TaskName}, Due: {task.DueDate}, Completed: {task.IsCompleted}");
        }
    }
}
