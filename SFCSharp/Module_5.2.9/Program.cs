using System;

namespace Module_5._2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var favcolor = new string[3];
            var name = "egor";

            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.WriteLine("Enter your color");
                favcolor[i] = Console.ReadLine();
            }

            ShowColor(name);
        }

        static void ShowColor(string username, params string[] favcolors)
        {
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
