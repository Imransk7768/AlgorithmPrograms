﻿using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome to Algorithm Programs  <<<<");
            bool end = true;
            Console.WriteLine("1. Binary Search\n2. InsertionSort\n3. Bubble Sort\n4. Merge Sort\n5. Anagram Detection\n   Otherthan Above Option(s) Program Ends");
            while (end == true)
            {
                Console.Write("Take an option to execute : ");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        BinarySearch binarySearch = new BinarySearch();
                        binarySearch.Binary();
                        break;
                    case 2:
                        InsertionSort sort = new InsertionSort();
                        const string filePath = @"H:\Assignments\AlgorithmPrograms\AlgorithmPrograms\ProgramData.txt";
                        string word = File.ReadAllText(filePath);
                        string[] names = word.Split(',');
                        sort.Insertion(names);
                        break;
                    case 3:
                        BubbleSort bubble = new BubbleSort();
                        bubble.BubbleSorting();
                        break;
                    case 4:
                        MergeSort merge = new MergeSort();
                        int[] arr2 = { 22, 12, 15, 7, 6, 5};
                        Console.Write("Array Values : ");
                        merge.PrintArray(arr2);
                        merge.Sorting(arr2, 0, arr2.Length - 1);
                        Console.Write("Sorted array : ");
                        merge.PrintArray(arr2);
                        break;
                    case 5:
                        AnagramDetection anagram = new AnagramDetection();
                        string s1 = "below ";
                        string s2 = "elbow";
                        Console.WriteLine(anagram.Anagram(s1, s2));
                        Console.WriteLine("Method2");
                        anagram.IsAnagram();
                        break;
                    default:
                        end = false;
                        Console.WriteLine("Program Ends.");
                        break;
                }
            }
        }
    }
}