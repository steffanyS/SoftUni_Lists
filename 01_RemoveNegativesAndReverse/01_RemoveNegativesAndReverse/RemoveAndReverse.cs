using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RemoveNegativesAndReverse
{
    class RemoveAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();

            if (numbers.Count() > 0)
            {
                foreach (var num in numbers)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.Write("empty");
            }
        }
    }
}
