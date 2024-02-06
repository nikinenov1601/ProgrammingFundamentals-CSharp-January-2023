

int input = int.Parse(Console.ReadLine());

PrintRow(input);

static void PrintRow(int input)
{
    for (int i = 0; i < input; i++)
    {
        PrintColumns(input);
    }
}

static void PrintColumns(int input)
{
    for (int j = 0; j < input; j++)
    {
        Console.Write(input + " ");
    }
    Console.WriteLine();
}