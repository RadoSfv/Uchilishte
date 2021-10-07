﻿using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumbers = numbers[i];
                if (currentNumbers % 2 == 0)
                {
                    evenSum += currentNumbers;
                }
                else
                {
                    oddSum += currentNumbers;
                }
            }
            int difference = evenSum - oddSum;
            Console.WriteLine(difference);
        }
    }
}
