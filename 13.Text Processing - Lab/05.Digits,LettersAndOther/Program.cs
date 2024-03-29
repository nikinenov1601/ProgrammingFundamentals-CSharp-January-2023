﻿
string text = Console.ReadLine();

List<string> letters = new List<string>();
List<string> digits = new List<string>();
List<string> symbols = new List<string>();

for (int i = 0; i < text.Length; i++)
{
    if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= 'A' && text[i] <= 'Z'))
    {
        letters.Add(text[i].ToString());
    }

    else if (text[i] >= '0' && text[i] <= '9')
    {
        digits.Add(text[i].ToString());
    }

    else
    {
        symbols.Add(text[i].ToString());
    }
}

Console.WriteLine(string.Join("", digits));
Console.WriteLine(string.Join("", letters));
Console.WriteLine(string.Join("", symbols));