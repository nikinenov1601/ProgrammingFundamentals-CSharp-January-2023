

int orders = int.Parse(Console.ReadLine());
double totalPrice = 0;
for (int i = 0; i < orders; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int daysInMonth = int.Parse(Console.ReadLine());
    int capsuleCount = int.Parse(Console.ReadLine());

    double price = ((daysInMonth * capsuleCount) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${price:f2}");

    totalPrice += price;
}
Console.WriteLine($"Total: ${totalPrice:f2}");