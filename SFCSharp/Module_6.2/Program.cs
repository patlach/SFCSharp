using System;

namespace Module_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Rectangle
        {
            public int x;
            public int y;

            public int Square(int a, int b)
            {
                int z = x * y;
                return z;
            }

            public Rectangle() // Конструктор без параметров по умолчанию;
            {
                x = 6;
                y = 4;
            }

            public Rectangle(int x, int y) //Конструктор с двумя параметрами
            {
                this.x = x;
                this.y = y;
            }

            public Rectangle(int x) //Конструктор с одним параметром
            {
                this.x = x;
                this.y = x;
            }
        }
    }
}
