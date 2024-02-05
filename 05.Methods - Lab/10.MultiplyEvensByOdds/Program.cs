using System;

namespace EvenOddMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
            Console.ReadLine();
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);

            return sumOfEven * sumOfOdd;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
