using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome to Algorithm Programs  <<<<");
            bool end = true;
            Console.WriteLine("1. Binary Search\n2. InsertionSort\n3. Bubble Sort\n4. Merge Sort\n5. Anagram Detection\n6. Prime Number\n" +
                "7. PalindromePrime\n8. Generic Sorting\n9. Find Number\n   Otherthan Above Option(s) Program Ends");
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
                    case 6:
                        PrimeNo prime = new PrimeNo();
                        prime.IsPrime();
                        break;
                    case 7:
                        PrimePalindrome pprime = new PrimePalindrome();
                        Console.WriteLine("Enter Initial Value");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Maximum Value");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        pprime.Palindrome(num1, num2);
                        break;
                    case 8:
                        GenericsSorting generics = new GenericsSorting();
                        int[] intt = { 22, 12, 15, 7, 6, 5 };
                        float[] flt = { 93.7f, 26.5f, 2.4f, 19.4f, 3.6f };
                        string[] stg = { "Rehan", "Shaik", "Andhra", "India" };
                        generics.SelectionSort<int>(intt);
                        generics.SelectionSort<float>(flt);
                        generics.SelectionSort<string>(stg);
                        generics.BubbleSort<int>(intt);
                        generics.BubbleSort<float>(flt);
                        generics.BubbleSort<string>(stg);
                        generics.InsertionSort<int>(intt);
                        generics.InsertionSort<float>(flt);
                        generics.InsertionSort<string>(stg);
                        break;
                    case 9:
                        FindNumber find = new FindNumber();
                        Console.WriteLine("Guess No between 0 to 160 ");
                        Console.WriteLine("Guess No is " + find.NumberFind());
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