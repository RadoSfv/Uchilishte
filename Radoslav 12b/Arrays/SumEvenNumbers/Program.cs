using System;
using System.Linq;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = numbers[i];
                if (currentNumbers % 2 == 0)
                {
                    sum += currentNumbers;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
