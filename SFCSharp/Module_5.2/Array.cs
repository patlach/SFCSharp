using System;
using System.Collections.Generic;
using System.Text;

namespace Module_5._2
{
    public class Array
    {
            public int[] GetArrayFromConsole(int num = 5)
            {
                var result = new int[num];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Enter {0} element of array", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }
                return result;
            }

            public int[] SortArray(int[] result)
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
                }

                return result;
            }
        public void ShowArray(int[] num, bool sort = false)
        {
            var temp = num; 
            if (sort)
            {
               num = SortArray(num);
            }
            
            foreach (int i in num)
            {
                Console.WriteLine("Your array is");
                Console.WriteLine(i);
            }
        }
    }
}
