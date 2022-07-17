using System;
using System.Linq;

namespace module_12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int[] array = Enumerable.Range(1,100).ToArray();
            Console.WriteLine(SearchElement(array, 7));
        }

		static int SearchElement(int[] array, int element)
        {
			int index;
			for (index = 0; index < array.Length; index++)
            {
				if (array[index] > element)
					return array[index];
            }

			return index;
        }

		static int BinarySearch(int value, int[] array, int left, int right)
		{
			while (left <= right)
			{
				var middle = (left + right) / 2;

				var midElement = array[middle];

				if (midElement == value)
				{
					return middle;
				}
				else if (value < midElement)
				{
					right = middle - 1;
				}
				else
				{
					left = middle + 1;
				}
			}

			return -1;
		}
	}
}
