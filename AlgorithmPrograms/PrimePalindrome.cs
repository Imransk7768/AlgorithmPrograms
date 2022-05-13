using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimePalindrome
    {
        public void Palindrome(int num1, int num2)
        {
            int a, rev, temp, i, num;
            Console.WriteLine("Palindrome Prime Numbers are :");
            for (num = num1; num <= num2; num++)
            {
                temp = num;
                a = 0;
                rev = 0;
                for (i = 1; i <= temp; i++)
                {
                    if (temp % i == 0)
                        a++;
                }
                if (a == 2)
                {
                    while (temp > 0)
                    {
                        rev = rev * 10 + (temp % 10);
                        temp = temp / 10;
                    }
                    if (rev == num)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }
    }
}
