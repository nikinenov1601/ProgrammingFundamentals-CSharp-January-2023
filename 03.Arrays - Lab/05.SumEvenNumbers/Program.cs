
int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).Where(x=> x % 2 == 0).ToArray();

int sum = 0;

for (int i = 0; i < arrayOfNumbers.Length; i++)
{
    sum += arrayOfNumbers[i];
}
Console.WriteLine(sum);
