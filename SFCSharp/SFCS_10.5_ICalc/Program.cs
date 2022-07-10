/*
Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел.
Определите интерфейс для функции сложения числа и реализуйте его.

Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.
 */

using System;

namespace SFCS_10._5_ICalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());

                ISum summ = new Summ();

                summ.Sum(a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
