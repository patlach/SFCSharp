using System;

namespace Module_5._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            var array = arr.GetArrayFromConsole(3);
            //var sortarray = arr.SortArray(array);
            arr.ShowArray(array);
        }
        //{
        //    var (name, age) = ("Егор", 29);

        //    //name = Console.ReadLine();

        //    var favcolors = new string[3];

        //    for (int i = 0; i < favcolors.Length; i++)
        //    {
        //        //or favcolors[i] = new colors().showcolor();
        //        favcolors[i] = ShowColor(name, age); 
        //    }

        //    foreach (var color in favcolors)
        //    {
        //        Console.WriteLine(color);
        //    }
        //}

        //static string ShowColor(string username, int userage)
        //{
        //    Console.WriteLine("{0}, {1} Напишите свой любимый цвет на английском с маленькой буквы", username, userage);
        //    var color = Console.ReadLine();

        //    switch (color)
        //    {
        //        case "red":
        //            Console.BackgroundColor = ConsoleColor.Red;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is red!");
        //            break;

        //        case "green":
        //            Console.BackgroundColor = ConsoleColor.Green;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is green!");
        //            break;
        //        case "cyan":
        //            Console.BackgroundColor = ConsoleColor.Cyan;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is cyan!");
        //            break;
        //        default:
        //            Console.BackgroundColor = ConsoleColor.Yellow;
        //            Console.ForegroundColor = ConsoleColor.Red;

        //            Console.WriteLine("Your color is yellow!");
        //            break;
        //    }

        //    return color;
        //}
    }
}
