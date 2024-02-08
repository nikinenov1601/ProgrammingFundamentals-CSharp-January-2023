string[] input = Console.ReadLine().Split('|').Reverse().ToArray();
string temporal = string.Join(" ", input);
string[] result = temporal.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
Console.WriteLine(string.Join(" ", result));