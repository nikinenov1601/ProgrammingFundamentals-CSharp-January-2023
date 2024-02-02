

float moneyAvailable = float.Parse(Console.ReadLine());

int studetsCount = int.Parse(Console.ReadLine());
float lightsaberPrice = float.Parse(Console.ReadLine());
float robesPrice = float.Parse(Console.ReadLine());
float beltsPrice = float.Parse(Console.ReadLine());

lightsaberPrice *=(float)Math.Ceiling(studetsCount * 1.1f);
robesPrice *= studetsCount;
beltsPrice *= (studetsCount - studetsCount / 6);

double cost = lightsaberPrice + robesPrice + beltsPrice;

if (moneyAvailable >= cost)
{
    Console.WriteLine($"The money is enough - it would cost {cost:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {cost - moneyAvailable:f2}lv more.");
}