int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int longestSequenceStart = 0;
int longestSequenceLenght = 0;


for (int i = 1; i < numbers.Length; i++)
{
    int currentSequence = i - 1;
    int currentSequenceLenght = 1;

    while (i < numbers.Length && numbers[i] == numbers[i - 1])
    {
        currentSequenceLenght++;
        i++;
    }
    if (currentSequenceLenght > longestSequenceLenght)
    {
        longestSequenceLenght = currentSequenceLenght;
        longestSequenceStart = currentSequence;
    }
}
for (int i = longestSequenceStart; i < longestSequenceStart + longestSequenceLenght; i++)
{
    Console.Write($"{numbers[i]} ");
}