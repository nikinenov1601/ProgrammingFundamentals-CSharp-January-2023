string[] input = Console.ReadLine().Split(' ');
int[] numbers = new int[input.Length];

for (int i = 0; i < input.Length; i++)
{
    numbers[i] = int.Parse(input[i]);
}

int targetSum = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] + numbers[j] == targetSum)
        {
            Console.WriteLine($"{numbers[i]} {numbers[j]}");
        }
    }
}