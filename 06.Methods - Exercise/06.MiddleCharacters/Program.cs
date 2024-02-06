using System;

string input = Console.ReadLine();
Console.WriteLine(GetMidCharacter(input));

static string GetMidCharacter(string input)
{
    string result = string.Empty;

    if (input.Length % 2 == 1)
    {
        result = input[input.Length / 2].ToString();
    }
    else
    {
        result = input[input.Length / 2-1] + input[input.Length / 2].ToString();
    }

    return result;
}