

int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool areEqual = true;

for (int i = 0; i < firstArray.Length; i++)
{

    if (firstArray[i] != secondArray[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        areEqual = false;
        break;
    }
}
if (areEqual)
{
    int sum = firstArray.Sum();
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}