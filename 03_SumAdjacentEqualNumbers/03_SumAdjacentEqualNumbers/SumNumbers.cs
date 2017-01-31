using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SumAdjacentEqualNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int count = 100;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        numbers[i-1] += numbers[i];
                        numbers.RemoveAt(i);
                        i=0;
                    }
                }

            Console.Write(string.Join(" ",numbers));
        }
    }
}
