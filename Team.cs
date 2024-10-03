using System;
using System.Collections.Generic;

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
