
string username = Console.ReadLine();
string correctPasssword = string.Empty;
string passwordAttempt = Console.ReadLine();
int incorrectPasswordAttempts = 0;

for (int i = username.Length-1; i >= 0; i--)
{
    correctPasssword += username[i];
}

while (passwordAttempt != correctPasssword)
{
    Console.WriteLine("Incorrect password. Try again.");
    passwordAttempt = Console.ReadLine();
    incorrectPasswordAttempts++;

    if (incorrectPasswordAttempts == 3)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }
    if (passwordAttempt == correctPasssword)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
}