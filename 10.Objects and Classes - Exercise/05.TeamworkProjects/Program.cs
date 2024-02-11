using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string name, string creator)
    {
        Name = name;
        Creator = creator;
        Members = new List<string>();
    }

    public void AddMember(string member)
    {
        Members.Add(member);
    }

    public override string ToString()
    {
        Members.Sort();
        return $"{Name}\n- {Creator}\n-- {string.Join("\n-- ", Members)}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numTeams = int.Parse(Console.ReadLine());
        Dictionary<string, Team> teams = new Dictionary<string, Team>();

        for (int i = 0; i < numTeams; i++)
        {
            string[] input = Console.ReadLine().Split("-");
            string creator = input[0];
            string teamName = input[1];

            if (teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (teams.Any(t => t.Value.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }
            else
            {
                Team team = new Team(teamName, creator);
                teams.Add(teamName, team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            string[] input = command.Split("->");
            string user = input[0];
            string teamName = input[1];

            if (!teams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            bool isAlreadyMember = teams.Any(t => t.Value.Creator == user || t.Value.Members.Contains(user));

            if (isAlreadyMember)
            {
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
            }
            else
            {
                teams[teamName].AddMember(user);
            }
        }

        var orderedTeams = teams.OrderByDescending(t => t.Value.Members.Count).ThenBy(t => t.Key);

        foreach (var team in orderedTeams.Where(t => t.Value.Members.Count > 0))
        {
            Console.WriteLine(team.Value);
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in orderedTeams.Where(t => t.Value.Members.Count == 0))
        {
            Console.WriteLine($"{team.Key}");
        }
    }
}
