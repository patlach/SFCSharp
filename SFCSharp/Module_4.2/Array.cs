using System;
using System.Collections.Generic;
using System.Text;

namespace Module_4._2
{
    public class Arr
    {
        public void Array()
        {
            var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
            int minValue = 100000, 
                minIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue) //100000, 6, 2
                {
                    minValue = numbers[i];
                    minIndex = i; //0, 4
                }
            }

            Console.WriteLine("min value into array has index {0}, this element has value {1}", minIndex, numbers[minIndex]);

            Console.ReadKey();
        }   

        public void Name()
        {
            Console.WriteLine("Enter your name");
            
            var name = Console.ReadLine();

            Console.WriteLine("Your name by letter");

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Последняя буква вашего имени: {0},", name[name.Length-1]);

            Console.ReadKey();
        }

        public void ReverceName()
        {
            Console.WriteLine("Enter your name");

            var name = Console.ReadLine();

            Console.WriteLine("Your reverce name by letter");

            for (int i = name.Length - 1 ; i >= 0; i--)
            {
                Console.WriteLine(name[i] + "");
            }
        }

        public void Matrix()
        {
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }
        }

        public void ArrayUp()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void ArraySum()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine(sum);
        }

        public void ArrayUnnormal() //Задание 4.3.14
        {
            int[][] array = new int[3][];

            array[0] = new int[2] {1, 2};
            array[1] = new int[3] {1, 2, 3};
            array[2] = new int[5] {1, 2, 3, 4, 5};

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void ArrayDemensional() //Задание 4.3.15
        {
            var array = new int[] {1, 2, 8, 2, -1, -2, 0, 1, -1};
            var numbers = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    numbers++ ;
                }             
            }

            Console.WriteLine(numbers);
        }

        public void Array2Demensional() //Задание 4.3.16
        {
            int[,] array = { { 5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            var numbers = 0;

            foreach (int num in array)
            {
                if (num > 0)
                {
                    numbers++;
                }
            }

            Console.WriteLine(numbers);
        }

        public void ArraySort() //Задание 4.3.17
        {
            int[,] array = { { 5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                {
                    for (int j = k+1; j < array.GetUpperBound(1) + 1; j++)
                    {
                        if (array[i, j] > array[i,k])
                        {
                            temp = array[i,k];
                            array[i, k] = array[i, j];
                            array[i,j] = temp;
                        }
                        //Console.WriteLine(array[j, k]);
                    }
                }
            }
        }
    }
}
