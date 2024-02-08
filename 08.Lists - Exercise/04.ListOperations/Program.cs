List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

string input = Console.ReadLine();

while (input != "End")
{
    string[] arrayedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = arrayedInput[0];

    switch (command)
    {
        case "Add":
            numbers.Add(command[1]);
            break;
        case "Insert":

            int index = int.Parse(arrayedInput[2]);

            if (index <= numbers.Count - 1 && index >= 0)
            {
                int number = int.Parse(arrayedInput[1]);
                numbers.Insert(index, number);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;
        case "Remove":
            int indexToRemove = int.Parse(arrayedInput[1]);

            if (indexToRemove <= numbers.Count - 1 && indexToRemove >= 0)
            {
                numbers.RemoveAt(indexToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;
        case "Shift":
            int count = int.Parse(arrayedInput[2]);

            if (arrayedInput[1] == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int firstNum = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add((int)firstNum);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    int lastNum = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, lastNum);
                }
            }
            break;
    }
    input = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));