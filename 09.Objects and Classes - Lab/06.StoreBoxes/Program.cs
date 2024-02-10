
string info = Console.ReadLine();

List<Box> boxes = new List<Box>();

while (info != "end")
{
    string[] infoAsArray = info.Split();


    string serialNumber = infoAsArray[0];
    string itemnName = infoAsArray[1];
    int itemQuantity = int.Parse(infoAsArray[2]);
    decimal itemPrice = decimal.Parse(infoAsArray[3]);

    Item item = new Item
    {
        Name = itemnName,
        Price = itemPrice,
    };

    Box box = new Box()
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = itemQuantity,
        PricePerBox = itemQuantity * itemPrice,
    };

    boxes.Add(box);


    info = Console.ReadLine();
}

foreach (var box in boxes.OrderByDescending(X => X.PricePerBox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PricePerBox:f2}");
}

class Box
{
    public string SerialNumber { get; set; }

    public Item Item { get; set; }

    public int ItemQuantity { get; set; }

    public decimal PricePerBox { get; set; }
}

class Item
{
    public string Name { get; set; }

    public decimal Price { get; set; }
}