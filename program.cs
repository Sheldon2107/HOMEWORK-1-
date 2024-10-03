using System;

public class Program
{
    public static void Main()
    {
        // Creating Team Members
        TeamMember member1 = new TeamMember("Nurul Aishah Elyani Binti Azhar", "Team Leader", "aishah@example.com");
        TeamMember member2 = new TeamMember("Nurul Fatihah Binti Rizwan", "Developer", "fatihah@example.com");
        TeamMember member3 = new TeamMember("Nadzira Binti Ramli", "Tester", "nadzira@example.com");
        TeamMember member4 = new TeamMember("Sheldon Stephen", "Developer", "sheldon@example.com");
        TeamMember member5 = new TeamMember("Nur Najla Alisa Binti Mat Suhairi", "Documentation Specialist", "najla@example.com");

        // Creating a Project
        Project project = new Project("Team Management System", DateTime.Now, DateTime.Now.AddMonths(2));

        // Creating Tasks
        Task task1 = new Task("Design System", "Design the architecture of the system", DateTime.Now.AddDays(10));
        Task task2 = new Task("Develop Backend", "Develop the backend using C#", DateTime.Now.AddDays(30));

        // Adding tasks to the project
        project.AddTask(task1);
        project.AddTask(task2);

        // Creating Team and assigning project
        Team team = new Team("Kampung Innovators");
        team.AddMember(member1);
        team.AddMember(member2);
        team.AddMember(member3);
        team.AddMember(member4);
        team.AddMember(member5);
        team.AssignProject(project);

        // Showing Project Summary
        project.GetProjectSummary();
    }
}
