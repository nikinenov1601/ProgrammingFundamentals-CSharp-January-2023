

int peopleCount = int.Parse(Console.ReadLine());
string typeOfGroup = Console.ReadLine();
string dayOfTheWeek = Console.ReadLine();

double totalPrice = 0;

if (typeOfGroup == "Students")
{
    switch (dayOfTheWeek)
    {
        case "Friday":
            totalPrice = peopleCount * 8.45;
            break;
        case "Saturday":
            totalPrice = peopleCount * 9.80;
            break;
        case "Sunday":
            totalPrice = peopleCount * 10.46;
            break;
    }
    if (peopleCount >= 30)
    {
        totalPrice = totalPrice * 0.85;
    }
}
else if (typeOfGroup == "Business")
{
    if (peopleCount >= 100)
    {
        peopleCount -= 10;
    }
    switch (dayOfTheWeek)
    {
        case "Friday":
            totalPrice = peopleCount * 10.90;
            break;
        case "Saturday":
            totalPrice = peopleCount * 15.60;
            break;
        case "Sunday":
            totalPrice = peopleCount * 16;
            break;
    }
}
else if (typeOfGroup == "Regular")
{
    switch (dayOfTheWeek)
    {
        case "Friday":
            totalPrice = peopleCount * 15;
            break;
        case "Saturday":
            totalPrice = peopleCount * 20;
            break;
        case "Sunday":
            totalPrice = peopleCount * 22.50;
            break;
    }
    if (peopleCount >= 10 && peopleCount <= 20)
    {
        totalPrice = totalPrice * 0.95;
    }
}
Console.WriteLine($"Total price: {totalPrice:f2}");