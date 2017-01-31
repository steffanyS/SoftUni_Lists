using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count(); i++)
            {
                var currentNumber = numbers[i];
                var square = Math.Sqrt(currentNumber);

                if(square==(int)square)
                {
                    Console.Write(numbers[i]+" ");
                }
            }
        }
    }
}
