using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_CountNumbers
{
    class Count
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Add(int.MaxValue);
            numbers.Sort();
            int count = 1;
            int previous = numbers[0];

            for (int i = 1; i < numbers.Count(); i++)
            {
                int current = numbers[i];
                if (current == previous)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}",previous,count);
                    count = 1;
                    previous = current;
                }
            }
        }
    }
}
