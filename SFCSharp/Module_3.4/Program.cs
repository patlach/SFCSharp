using System;

namespace Module_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek myFavorite;

            myFavorite = DayOfWeek.Wednesday;

            Console.WriteLine(myFavorite);

            int olddata = 6;
            int data = olddata;

            Console.ReadLine();
        }

        enum DaysOfWeek : byte
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300,
        }

    }
}
