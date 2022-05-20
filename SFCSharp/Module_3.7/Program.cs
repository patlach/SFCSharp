using System;

namespace Module_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            byte age = (byte)int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your birthday: ");
            var birthday = Console.ReadLine();

            Console.WriteLine("Your name is {0} and age is {1} and birthday {2} ", name, age, birthday);

            Console.WriteLine("What is your favorite day of week?");
            DayOfWeek day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your day of week is {0}", day);

            Console.ReadKey();
        }
        
        enum DayOFWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
