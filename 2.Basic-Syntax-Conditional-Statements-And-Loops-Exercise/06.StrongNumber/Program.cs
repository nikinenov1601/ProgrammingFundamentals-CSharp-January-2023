

int number = int.Parse(Console.ReadLine());

int numberCopy = number;

int sum = 0;

while (numberCopy > 0)
{
    int digit = numberCopy % 10;
    numberCopy /= 10;
    int factoriel = 1;

    for (int i = 1; i <= digit; i++)
    {
        factoriel *= i;
    }

    sum += factoriel;
}

if (number == sum)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}