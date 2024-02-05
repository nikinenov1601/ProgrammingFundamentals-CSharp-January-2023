internal class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double finalResult = RaiseToPower(number, power);
        Console.WriteLine(finalResult);
    }
    static double RaiseToPower(double number, int power)
    {
        double result = 0d;
        result = Math.Pow(number, power);
        return result;
    }
}