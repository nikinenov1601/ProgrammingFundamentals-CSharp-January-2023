List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

int maxCapacityofWagon = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

while (input != "end")
{
    string[] commad = input.Split(" ");

    if (commad.Length == 2)
    {
        int passenger = int.Parse(commad[1]);
        wagons.Add(passenger);
    }
    else
    {
        int passenger = int.Parse(commad[0]);

        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passenger <= maxCapacityofWagon)
            {
                wagons[i] += passenger;
                break;
            }
        }
    }
    input = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", wagons));