double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double factorialFirstNumber = FactorialFirstMethod(firstNumber);
double factorialSecondNumber = FactorialSecondMethord(secondNumber);

double factorialSubstract = factorialFirstNumber / factorialSecondNumber;
Console.WriteLine($"{factorialSubstract:f2}");

double FactorialFirstMethod(double firstNumber)
{
    double factorialFirst = 1;

    for (int i = 1; i <= firstNumber; i++)
    {
        factorialFirst *= i;
    }
    return factorialFirst;
}

double FactorialSecondMethord(double secondNumber)
{
    double factorialSecond = 1;

    for (int i = 1; i <= secondNumber; i++)
    {
        factorialSecond *= i;
    }
    return factorialSecond;
}