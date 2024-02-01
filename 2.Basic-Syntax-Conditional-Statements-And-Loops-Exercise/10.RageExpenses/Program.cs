

int number = int.Parse(Console.ReadLine());

float headsetPrice = float.Parse(Console.ReadLine());
float mousetPrice = float.Parse(Console.ReadLine());
float keyboardPrice = float.Parse(Console.ReadLine());
float displayPrice = float.Parse(Console.ReadLine());

int headset = number / 2;
int mouse = number / 3;
int keyboard = number / 6;
int display = number / 12;

float totalRageExpenses = headset * headsetPrice + mouse * mousetPrice + keyboard * keyboardPrice + display * displayPrice;

Console.WriteLine($"Rage expenses: {totalRageExpenses:f2} lv.");