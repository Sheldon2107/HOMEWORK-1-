using System;
using System.Collections.Generic;


public class TeamMember
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }

    public TeamMember(string name, string role, string email)
    {
        Name = name;
        Role = role;
        Email = email;
    }

    public void AssignTask(Task task)
    {
        Console.WriteLine($"{Name} has been assigned the task: {task.TaskName}");
    }

    public void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Role: {Role}, Email: {Email}");
    }
}


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


public class Team
{
    public string TeamName { get; set; }
    public List<TeamMember> TeamMembers { get; set; }
    public Project Project { get; set; }

    public Team(string teamName)
    {
        TeamName = teamName;
        TeamMembers = new List<TeamMember>();
    }

    public void AddMember(TeamMember member)
    {
        TeamMembers.Add(member);
        Console.WriteLine($"Team member {member.Name} added to team {TeamName}.");
    }

    public void RemoveMember(TeamMember member)
    {
        TeamMembers.Remove(member);
        Console.WriteLine($"Team member {member.Name} removed from team {TeamName}.");
    }

    public void AssignProject(Project project)
    {
        Project = project;
        Console.WriteLine($"Project {project.ProjectName} assigned to team {TeamName}.");
    }
}


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


public class Program
{
    public static void Main()
    {
        
        TeamMember member1 = new TeamMember("Nurul Aishah Elyani Binti Azhar", "Team Leader", "aishah@example.com");
        TeamMember member2 = new TeamMember("Nurul Fatihah Binti Rizwan", "Developer", "fatihah@example.com");
        TeamMember member3 = new TeamMember("Nadzira Binti Ramli", "Tester", "nadzira@example.com");
        TeamMember member4 = new TeamMember("Sheldon Stephen", "Developer", "sheldon@example.com");
        TeamMember member5 = new TeamMember("Nur Najla Alisa Binti Mat Suhairi", "Documentation Specialist", "najla@example.com");

        
        Project project = new Project("Team Management System", DateTime.Now, DateTime.Now.AddMonths(2));


        Task task1 = new Task("Design System", "Design the architecture of the system", DateTime.Now.AddDays(10));
        Task task2 = new Task("Develop Backend", "Develop the backend using C#", DateTime.Now.AddDays(30));

        
        project.AddTask(task1);
        project.AddTask(task2);

       
        Team team = new Team("Kampung Innovators");
        team.AddMember(member1);
        team.AddMember(member2);
        team.AddMember(member3);
        team.AddMember(member4);
        team.AddMember(member5);
        team.AssignProject(project);

        project.GetProjectSummary();
    }
}
