using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class GenericsSorting
    {
        public void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("\nAfter Bubble Sorting  : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        public void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[minIndex].CompareTo(arr[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                T temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            Console.Write("\nAfter Selection Sorting  : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        public void InsertionSort<T>(T[] array) where T : IComparable<T>
        {
            int i, j;
            for (i = 1; i < array.Length; i++)
            {
                T valueGiven = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(valueGiven) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = valueGiven;
            }
            Console.Write("\nAfter Insertion Sorting  : ");
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
            Console.Write("\n");
        }
    }
}
