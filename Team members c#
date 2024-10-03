using System;

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
