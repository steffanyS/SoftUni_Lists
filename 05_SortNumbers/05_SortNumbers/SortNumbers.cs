using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();

            foreach (var num in numbers)
            {
                Console.Write(num+" <= ");
            }
        }
    }
}
