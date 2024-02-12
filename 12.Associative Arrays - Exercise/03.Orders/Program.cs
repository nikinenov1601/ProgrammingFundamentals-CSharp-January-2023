
Dictionary<string, double[]> orders = new Dictionary<string, double[]>();

string input = Console.ReadLine();


while (input != "buy")
{
    string[] inputSplit = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string product = inputSplit[0];
    double price = double.Parse(inputSplit[1]);
    double quantity = double.Parse(inputSplit[2]);

    if (!orders.ContainsKey(product))
    {
        orders[product] = new double[2];
    }

    orders[product][0] = price;
    orders[product][1] += quantity;

    input = Console.ReadLine();
}

foreach (var product in orders)
{
    double totalPrice = product.Value[0] * product.Value[1];

    Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
}
