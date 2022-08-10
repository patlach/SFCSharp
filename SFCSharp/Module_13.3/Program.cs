using System;
using System.Collections.Generic;

namespace Module_13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exit = true;

            while (exit)
            {
                Console.WriteLine("For exit enter 'exit'. Enter your sentence for count unique symbols.");
                string str = Console.ReadLine();

                if (str == "exit")
                {
                    exit = false;
                }

                var punctuation = new[] { ',', '.', ' ' };

                var numbers = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

                var symbols = str.ToCharArray();

                var uniqSymbols = new HashSet<char>();

                foreach (char symbol in symbols)
                {
                    uniqSymbols.Add(symbol);
                }

                Console.WriteLine("Have string: {0}", str);

                Console.WriteLine(uniqSymbols.Count);

                uniqSymbols.ExceptWith(punctuation);

                Console.WriteLine("Without punctuation {0}", uniqSymbols.Count);

                bool isContainsNumber = uniqSymbols.Overlaps(numbers);

                Console.WriteLine("Is this string contains numbers: {0}", isContainsNumber);
            }
        }

    }
}
