string[] words = Console.ReadLine().Split().Where(words => words.Length % 2 == 0).ToArray();

Console.WriteLine(string.Join(Environment.NewLine, words));