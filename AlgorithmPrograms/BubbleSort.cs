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
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
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
