internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        RepeatString(input, n);
    }
    private static string RepeatString(string str, int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            Console.Write(str + "");
        }
        return result;
    }
}