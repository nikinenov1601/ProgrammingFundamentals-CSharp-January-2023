
using System.Diagnostics;
using System.Xml.Linq;

string input = Console.ReadLine();
Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

while (input != "End")
{
    string[] inputSplit = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string companyName = inputSplit[0];
    string employeeId = inputSplit[1];

    if (!companyUsers.ContainsKey(companyName))
    {
        companyUsers[companyName] = new List<string>();

    }


    if (!companyUsers[companyName].Contains(employeeId))
    {
        companyUsers[companyName].Add(employeeId);
    }

    input = Console.ReadLine();
}

foreach (var kvp in companyUsers)
{
    Console.WriteLine($"{kvp.Key}");

    foreach (var user in kvp.Value)
    {
        Console.WriteLine($"-- {user}");
    }
}
