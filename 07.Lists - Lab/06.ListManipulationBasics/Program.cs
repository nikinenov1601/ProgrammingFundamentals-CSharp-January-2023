List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

while (true)
{
    string line = Console.ReadLine();

    if (line == "end")
    {
        break;
    }

    string[] token = line.Split();

    if (token[0] == "Add")
    {
        numbers.Add(int.Parse(token[1]));
    }
    else if (token[0] == "Remove")
    {
        numbers.Remove(int.Parse(token[1]));
    }
    else if (token[0] == "RemoveAt")
    {
        numbers.RemoveAt(int.Parse(token[1]));
    }
    else if (token[0] == "Insert")
    {
        int NumberToInsert = int.Parse(token[1]);
        int IndexToInsert = int.Parse(token[2]);

        numbers.Insert(IndexToInsert, NumberToInsert);
    }
}

Console.WriteLine(string.Join(" ", numbers));