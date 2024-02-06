
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int resultSum = Sum(num1, num2);
int finalResult = SubtractFromSum(resultSum, num3);

Console.WriteLine(finalResult);

int Sum(int num1, int num2)
{
    return num1 + num2;
}

int SubtractFromSum(int resultSum, int num3)
{
    return resultSum - num3;
}