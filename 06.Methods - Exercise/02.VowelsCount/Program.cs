string input = Console.ReadLine();

int vowelsCount = PrintingOutNumberOfVowels(input);

int PrintingOutNumberOfVowels(string input)
{
    int vowelsCount = 0;

    for (int i = 0; i < input.Length; i++)
    {
        char letter = input[i];

        if (letter == 'a' || letter == 'y' || letter == 'o' || letter == 'u' || letter == 'e' || letter == 'i' || letter == 'A' || letter == 'Y' || letter == 'O' || letter == 'U' || letter == 'E' || letter == 'I')
        {
            vowelsCount++;
        }
    }
    Console.WriteLine(vowelsCount);
    return vowelsCount;
}