
string words = Console.ReadLine();

Dictionary<char, int> letters = new Dictionary<char, int>();

foreach (char currentChar in words)
{
    if (currentChar == ' ')
    {
        continue;
    }

    if (!letters.ContainsKey(currentChar))
    {
        letters[currentChar] = 0;
    }

    letters[currentChar]++;
}

foreach (var item in letters)
{

    Console.WriteLine($"{item.Key} -> {item.Value}");
}