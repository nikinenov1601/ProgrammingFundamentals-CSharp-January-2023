
int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
{
    for (int j = 0; j < arrayOfNumbers.Length - 1 - i; j++)
    {
        arrayOfNumbers[j] = arrayOfNumbers[j] + arrayOfNumbers[j + 1];

    }
}
Console.WriteLine(arrayOfNumbers[0]);