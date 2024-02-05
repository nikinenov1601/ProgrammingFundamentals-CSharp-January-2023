﻿using System.Runtime.ExceptionServices;

internal class Program
{
    static void Main()
    {
        string command = Console.ReadLine();

        if (command == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            GetMax(first, second);
        }
        else if (command == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            GetMax(first, second);
        }
        else if (command == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            GetMax(first, second);
        }
    }
    static int GetMax(int first, int second)
    {
        int result = 0;

        if (first > second)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        Console.WriteLine(result);
        return result;
    }
    static char GetMax(char first, char second)
    {
        int result;

        if (first > second)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        Console.WriteLine((char)result);
        return (char)result;
    }
    static string GetMax(string first, string second)
    {
        string result = string.Empty;
        int comparison = first.CompareTo(second);
        if (comparison > 0)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        Console.WriteLine(result);
        return (result);
    }
}