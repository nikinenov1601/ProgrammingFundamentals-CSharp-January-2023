﻿char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());

if (first > second)
{
    char temp = first;
    first = second;
    second = temp;
}
for (int i = first + 1; i < second; i++)
{
    Console.Write((char)i + " ");
}