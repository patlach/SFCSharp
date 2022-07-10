/*
Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер,
используя материал из скринкаста юнита 10.1.

Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет. 
*/

using SFCS_10._5_ICalcWithLogger.Contracts;
using SFCS_10._5_ICalcWithLogger.Logics;
using System;

namespace SFCS_10._5_ICalcWithLogger
{
    internal class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {

            try
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());

                Logger = new Logger();

                ISum summ = new Summ(Logger);

                summ.Sum(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
