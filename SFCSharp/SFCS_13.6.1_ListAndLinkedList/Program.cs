using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SFCS_13._6._1_ListAndLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to file: ");
            string path = @"C:\Users\epolushin\Downloads\Text1.txt";//Console.ReadLine();

            string[] lines = File.ReadAllLines(path);

            TimesToIsertInList(lines);

            TimesToIsertInLinkedList(lines);
        }

        static void TimesToIsertInList(string[] lines)
        {
            List<string> list = new List<string>();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (string line in lines)
            {
                list.Add(line);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }

        static void TimesToIsertInLinkedList(string[] lines)
        {
            List<string> list = new List<string>();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            foreach (string line in lines)
            {
                list.Add(line);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
