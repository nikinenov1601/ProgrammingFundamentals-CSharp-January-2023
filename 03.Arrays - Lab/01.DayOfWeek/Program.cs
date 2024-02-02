
string[] dayOfTheWeek = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    Console.WriteLine(dayOfTheWeek[number]);
}
else
{
    Console.WriteLine(dayOfTheWeek[0]);
}
