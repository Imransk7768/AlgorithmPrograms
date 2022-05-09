using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSort
    {
        public void Merge(int[] arr2, int l, int m, int r)
        {
            int a = m - l + 1;
            int b = r - m;

            int[] L = new int[a];
            int[] R = new int[b];
            int i, j;

            for (i = 0; i < a; ++i)
                L[i] = arr2[l + i];
            for (j = 0; j < b; ++j)
                R[j] = arr2[m + 1 + j];
            i = 0;
            j = 0;
            int k = l;
            while (i < a && j < b)
            {
                if (L[i] <= R[j])
                {
                    arr2[k] = L[i];
                    i++;
                }
                else
                {
                    arr2[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < a)
            {
                arr2[k] = L[i];
                i++;
                k++;
            }
            while (j < b)
            {
                arr2[k] = R[j];
                j++;
                k++;
            }
        }
        public void Sorting(int[] arr2, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                Sorting(arr2, l, m);
                Sorting(arr2, m + 1, r);
                Merge(arr2, l, m, r);
            }
        }
        public void PrintArray(int[] arr2)
        {
            int n = arr2.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr2[i] + " ");
            Console.WriteLine();
        }
    }
}