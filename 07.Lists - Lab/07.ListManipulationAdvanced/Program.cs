List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
List<int> oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

int sum = 0;

while (true)
{
    string command = Console.ReadLine();
    string[] commandInfo = command.Split();


    if (command == "end")
    {
        break;
    }

    if (commandInfo[0] == "Add")
    {
        numbers.Add(int.Parse(commandInfo[1]));
    }
    else if (commandInfo[0] == "Remove")
    {
        numbers.Remove(int.Parse(commandInfo[1]));
    }
    else if (commandInfo[0] == "RemoveAt")
    {
        numbers.RemoveAt(int.Parse(commandInfo[1]));
    }
    else if (commandInfo[0] == "Insert")
    {
        int NumberToInsert = int.Parse(commandInfo[1]);
        int IndexToInsert = int.Parse(commandInfo[2]);

        numbers.Insert(IndexToInsert, NumberToInsert);
    }
    else if (commandInfo[0] == "Contains")
    {
        int containedNumber = int.Parse(commandInfo[1]);

        if (numbers.Contains(containedNumber))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }

    else if (command == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", evenNumbers));
    }

    else if (command == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", oddNumbers));
    }

    else if (command == "GetSum")
    {
        sum = numbers.Sum(x => x);
        Console.WriteLine(sum);
    }

    else if (commandInfo[0] == "Filter")
    {
        string filterCommand = commandInfo[1];
        int filteredNumber = int.Parse(commandInfo[2]);

        if (filterCommand == "<")
        {
            List<int> smallerThan = numbers.Where(x => x < filteredNumber).ToList();
            Console.WriteLine(string.Join(" ", smallerThan));
        }
        else if (filterCommand == ">")
        {
            List<int> biggerThan = numbers.Where(x => x > filteredNumber).ToList();
            Console.WriteLine(string.Join(" ", biggerThan));
        }
        else if (filterCommand == ">=")
        {
            List<int> biggerThanOrEqualTo = numbers.Where(x => x >= filteredNumber).ToList();
            Console.WriteLine(string.Join(" ", biggerThanOrEqualTo));
        }
        else if (filterCommand == "<=")
        {
            List<int> smallerThanOrEqualTo = numbers.Where(x => x <= filteredNumber).ToList();
            Console.WriteLine(string.Join(" ", smallerThanOrEqualTo));
        }
    }
}