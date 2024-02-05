internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Method(1, i);
        }
        for (int i = n - 1; i >= 1; i--)
        {
            Method(1, i);
        }
    }
    static void Method(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}