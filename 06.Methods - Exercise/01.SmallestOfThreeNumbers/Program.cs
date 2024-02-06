

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int thirdNumber = int.Parse(Console.ReadLine());

int smallestNumber = PrintingOutSmallestNumber(firstNumber, secondNumber, thirdNumber);

int PrintingOutSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
{
    int smallestNumber = 0;
    if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
    {
        smallestNumber = firstNumber;
    }
    else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
    {
        smallestNumber = secondNumber;
    }
    else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
    {
        smallestNumber = thirdNumber;
    }
    Console.WriteLine(smallestNumber);
    return smallestNumber;
}