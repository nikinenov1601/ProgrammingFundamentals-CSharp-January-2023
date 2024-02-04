
int number = int.Parse(Console.ReadLine());
int[] firstArray = new int[number];
int[] secondArray = new int[number];

for (int i = 0; i < number; i++)
{
    int[] arrayOfNumbersToAdd = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = arrayOfNumbersToAdd[0];
        secondArray[i] = arrayOfNumbersToAdd[1];
    }
    else
    {
        firstArray[i] = arrayOfNumbersToAdd[1];
        secondArray[i] = arrayOfNumbersToAdd[0];
    }
}
    Console.WriteLine(String.Join(" ", firstArray));
    Console.WriteLine(String.Join(" ", secondArray));