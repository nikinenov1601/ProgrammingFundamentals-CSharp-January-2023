

int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int oddNumberSum = arrayOfNumbers.Where(x => x % 2 != 0).Sum();

int evenNumberSum = arrayOfNumbers.Where(x => x % 2 == 0).Sum();

Console.WriteLine(evenNumberSum - oddNumberSum);