
string[] words = Console.ReadLine().Split(); // Welcome[0] to[1] SoftUni[2] and[3] have[4] fun[5] learning[6] programming[7]

for (int i = 0; i < words.Length; i++) // Length = 8
{

    Random random = new Random(); // Random sequence generator

    int randonIndex = random.Next(0, words.Length - 1); // [0] -> [7]

    string currentWord = words[i];
    string wordToSwap = words[randonIndex];

    words[i] = wordToSwap;
    words[randonIndex] = currentWord;
}

Console.WriteLine(string.Join(Environment.NewLine, words));