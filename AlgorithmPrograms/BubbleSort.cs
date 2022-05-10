using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        int temp = 0;
        public void BubbleSorting()
        {
            int[] arr = { 700, 22, 70, 555, 720, 820, 330, 12 };
            Console.Write("Before Bubble Sorting : ");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index] + " ");
            }
            for (int ind = 0; ind < arr.Length; ind++)
            {
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        temp = arr[k + 1];
                        arr[k + 1] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            Console.Write("\nAfter Bubble Sorting  : ");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(arr[index] + " ");
            }
            Console.WriteLine(".");
        }
    }
}
