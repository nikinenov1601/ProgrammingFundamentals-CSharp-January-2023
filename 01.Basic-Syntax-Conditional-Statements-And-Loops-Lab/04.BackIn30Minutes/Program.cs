
int h = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine()) + 30;

if (m >= 60)
{
    h += 1;
    m -= 60;
}

if (h >= 24)
{
    h = 0;
}
Console.WriteLine($"{h}:{m:d2}");