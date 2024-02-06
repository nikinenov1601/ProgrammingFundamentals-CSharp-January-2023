using System.ComponentModel;

string password = Console.ReadLine();
bool isValid = true;

if (!BetweenSixandTenCharacters(password))
{
    isValid = false;
    Console.WriteLine("Password must be between 6 and 10 characters");
}

if (!OnlyLettersAndDigits(password))
{
    isValid = false;
    Console.WriteLine("Password must consist only of letters and digits");
}

if (!AtLeastTwoDigits(password))
{
    isValid = false;
    Console.WriteLine("Password must have at least 2 digits");
}

if (isValid)
{
    Console.WriteLine("Password is valid");
}

bool BetweenSixandTenCharacters(string password)
{
    return password.Length is >= 6 and <= 10;
}

bool OnlyLettersAndDigits(string password)
{
    return password.All(char.IsLetterOrDigit);
}

bool AtLeastTwoDigits(string password)
{
    return password.Count(char.IsDigit) >= 2;
}