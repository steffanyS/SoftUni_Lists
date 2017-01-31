using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SplitByWordCasing
{
    class Split
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ',', ';', ':', '.', '!', ')', '(', '"', '\\', '/', ']', '[', ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();
            int lowerCount = 0;
            int upperCount = 0;

            foreach (var word in input)
            {
                foreach (var letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCount++;
                    }
                    else if(char.IsUpper(letter))
                    {
                        upperCount++;
                    }
                }

                if (lowerCount == word.Length)
                {
                    lowerCase.Add(word);
                }
                else if (upperCount == word.Length)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }

                lowerCount = 0;
                upperCount = 0;
            }

            Console.WriteLine("Lower-case: " + String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCase));

        }
    }
}
