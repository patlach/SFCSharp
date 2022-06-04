using System;

namespace Module_5._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter {0} element of array", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            SortArray(array, out int[] sorteddesc, out int[] sortedasc);
        }

        private static void SortArray(int[] array, out int[] sorteddesc,out int[] sortedasc)
        {
            sorteddesc = SortArrayDesk(array);
            sortedasc = SortArrayAsc(array);
        }
        static int[] SortArrayAsc(int[] result)
        {
            int temp = 0;

            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

            Console.WriteLine("Your sort array");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            };
            return result;
        }

        static int[] SortArrayDesk(int[] result)
        {
            int temp = 0;

            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1; j < result.Length; j++)
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }

            Console.WriteLine("Your sort array");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            return result;
        }
    }
}
