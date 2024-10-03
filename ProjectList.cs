using System;
using System.Collections.Generic;

public class ProjectList
{
    public List<Project> ListOfProjects { get; set; }

    public ProjectList()
    {
        ListOfProjects = new List<Project>();
    }

    public void AddProject(Project project)
    {
        ListOfProjects.Add(project);
        Console.WriteLine($"Project {project.ProjectName} added.");
    }

    public void RemoveProject(Project project)
    {
        ListOfProjects.Remove(project);
        Console.WriteLine($"Project {project.ProjectName} removed.");
    }

    public void GetAllProjects()
    {
        foreach (var project in ListOfProjects)
        {
            Console.WriteLine($"Project: {project.ProjectName}, Start Date: {project.StartDate}, End Date: {project.EndDate}");
        }
    }
}
