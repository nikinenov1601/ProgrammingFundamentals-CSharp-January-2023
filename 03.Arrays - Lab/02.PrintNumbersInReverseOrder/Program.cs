
int count = int.Parse(Console.ReadLine());
int[] arrayOfNumbers = new int[count];

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());
    arrayOfNumbers[i] = number;
}
Array.Reverse(arrayOfNumbers);
Console.WriteLine(String.Join(" ", arrayOfNumbers));