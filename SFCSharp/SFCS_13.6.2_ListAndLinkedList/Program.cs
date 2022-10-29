using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SFCS_13._6._2_ListAndLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\Text1.txt";

            StreamReader reader = new StreamReader(path);

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            var text = reader.ReadToEnd();

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            string[] splitText = noPunctuationText.Split(' ');

            foreach (string word in splitText)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value).Take(10))
            {
                Console.WriteLine($"words {item.Key} is repeated {item.Value} times");
            }

        }
    }
}
