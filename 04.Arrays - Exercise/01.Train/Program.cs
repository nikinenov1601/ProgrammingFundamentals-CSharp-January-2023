

int n = int.Parse(Console.ReadLine());
int[] arrayOfNumbers = new int[n];

for (int i = 0; i < n; i++)
{
    int addedNumber = int.Parse(Console.ReadLine());
    arrayOfNumbers[i] = addedNumber;
}
Console.WriteLine(String.Join(" ", arrayOfNumbers));
Console.WriteLine(arrayOfNumbers.Sum());