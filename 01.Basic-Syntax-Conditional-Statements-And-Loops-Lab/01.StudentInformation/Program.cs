
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double averagescore = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averagescore:f2}");