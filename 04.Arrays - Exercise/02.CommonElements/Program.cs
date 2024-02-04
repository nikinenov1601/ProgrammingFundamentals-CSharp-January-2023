

string[] firstArray = Console.ReadLine().Split();
string[] secondArray = Console.ReadLine().Split();

for (int i = 0; i < secondArray.Length; i++)
{
    string currString = secondArray[i];

    for (int j = 0; j < firstArray.Length; j++)
    {
        if (currString == firstArray[j])
        {
            Console.Write(currString + " ");
        }
    }
}