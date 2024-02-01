
int firstnumber = int.Parse(Console.ReadLine());
int secondnumber = int.Parse(Console.ReadLine());

while (secondnumber < 10)
{
    Console.WriteLine($"{firstnumber} X {secondnumber} = {firstnumber * secondnumber}");
    secondnumber++;
}
if (secondnumber >= 10)
{
    Console.WriteLine($"{firstnumber} X {secondnumber} = {firstnumber * secondnumber}");
}