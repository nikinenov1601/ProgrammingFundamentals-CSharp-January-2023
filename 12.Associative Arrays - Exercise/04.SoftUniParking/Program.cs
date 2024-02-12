
int n = int.Parse(Console.ReadLine());

Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] inputSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

    string command = inputSplit[0];
    string username = inputSplit[1];

    if (!keyValuePairs.ContainsKey(username) && command == "register")
    {
        keyValuePairs.Add(username, inputSplit[2]);
        Console.WriteLine($"{username} registered {inputSplit[2]} successfully");
    }
    else if (keyValuePairs.ContainsKey(username) && command == "register")
    {
        Console.WriteLine($"ERROR: already registered with plate number {inputSplit[2]}");
    }
    else if (!keyValuePairs.ContainsKey(username) && command == "unregister")
    {
        Console.WriteLine($"ERROR: user {username} not found");
    }
    else if (keyValuePairs.ContainsKey(username) && command == "unregister")
    {
        keyValuePairs.Remove(username);
        Console.WriteLine($"{username} unregistered successfully");
    }
}

foreach (var kvp in keyValuePairs)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}