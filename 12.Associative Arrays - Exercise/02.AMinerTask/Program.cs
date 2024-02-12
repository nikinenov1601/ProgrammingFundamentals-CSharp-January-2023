string resources = Console.ReadLine();

Dictionary<string, int> mine = new Dictionary<string, int>();

while (resources != "stop")
{

    int quantity = int.Parse(Console.ReadLine());

    if (mine.ContainsKey(resources))
    {
        mine[resources] += quantity;
    }

    else
    {
        mine.Add(resources, quantity);
    }

    resources = Console.ReadLine();
}

foreach (var kvp in mine)
{

    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}
