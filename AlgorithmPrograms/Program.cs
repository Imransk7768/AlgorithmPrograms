using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">>>>  Welcome to Algorithm Programs  <<<<");
            bool end = true;
            Console.WriteLine("1. Binary Search\n   Otherthan Above Option(s) Program Ends");
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
                    default:
                        end = false;
                        Console.WriteLine("Program Ends.");
                        break;
                }
            }
        }
    }
}