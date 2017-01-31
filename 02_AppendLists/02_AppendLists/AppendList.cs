using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AppendLists
{
    class AppendList
    {
        static void Main(string[] args)
        {
            List<string> result = new List<string>();
            List<string> stringNumbers = Console.ReadLine().Split('|').ToList();
            stringNumbers.Reverse();

            new List<string>();

            foreach (var item in stringNumbers)
            {
                List<string> items = item.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(items);
            }
            Console.WriteLine(String.Join(" ", result));
        }


    }
}

