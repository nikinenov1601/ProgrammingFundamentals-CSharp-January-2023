internal class Program
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        string stringOperator = Console.ReadLine();
        int secondNumber = int.Parse(Console.ReadLine());
        Calculate(firstNumber, stringOperator, secondNumber);

    }
    private static double Calculate(int firstNumber, string Operator, int secondNumber)
    {
        double result = 0;

        switch (Operator)
        {
            case "/":
                result = firstNumber / secondNumber;
                break;
            case "*":
                result = firstNumber * secondNumber;
                break;
            case "+":
                result = firstNumber + secondNumber;
                break;
            case "-":
                result = firstNumber - secondNumber;
                break;
        }
        Console.WriteLine(result);
        return result;
    }
}