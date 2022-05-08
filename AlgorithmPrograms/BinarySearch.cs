using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void Binary()
        {
            bool search = false;
            const string filepath = @"H:\Assignments\AlgorithmPrograms\AlgorithmPrograms\ProgramData.txt";
            string list = File.ReadAllText(filepath);
            string[] arr = list.Split(" ");
            Console.WriteLine("Enter The Word");
            string name = Console.ReadLine();
            foreach (string word in arr)
            {
                if (word.Equals(name))
                {
                    search = true;
                    Console.WriteLine("'" + name + "' Word Is Present/Exist.");
                }
            }
            if (search == false)
            {
                Console.WriteLine("Word '" + name + "' Is Not Present/Exist.");
            }
        }
    }
}
