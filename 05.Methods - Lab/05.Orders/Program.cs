internal class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        if (product == "coffee")
        {
            Coffee(quantity);
        }
        else if (product == "water")
        {
            Water(quantity);
        }
        else if (product == "coke")
        {
            Coke(quantity);
        }
        else if (product == "snacks")
        {
            Snacks(quantity);
        }
    }
    static void Coffee(double n)
    {
        Console.WriteLine($"{n * 1.50:f2}");
    }
    static void Water(double n)
    {
        Console.WriteLine($"{n * 1.00:f2}");
    }
    static void Coke(double n)
    {
        Console.WriteLine($"{n * 1.40:f2}");
    }
    static void Snacks(double n)
    {
        Console.WriteLine($"{n * 2.00:f2}");
    }
}