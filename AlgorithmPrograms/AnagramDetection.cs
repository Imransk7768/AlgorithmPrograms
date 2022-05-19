using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        public bool Anagram(string length1, string length2)
        {
            var lnt1 = length1.ToLower().ToArray();
            var lnt2 = length2.ToLower().ToArray();
            Array.Sort(lnt1);
            Array.Sort(lnt2);
            string val1 = new string(lnt1);
            string val2 = new string(lnt2);
            return new string(lnt1) == new string(lnt2);
        }
        public void IsAnagram()
        {
            string str1 = "act";
            string str2 = "cat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("GIven Words are Anagrams");
            }
            else
            {
                Console.WriteLine("Given Words Are Not Anagrams");
            }
        }
    }
}
