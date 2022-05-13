using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class FindNumber
    {
        int first = 0, last = 160, mid,num;
        public int NumberFind()
        {
            while (first != last)
            {
                mid = (first + last) / 2;
                Console.WriteLine("Enter Number1 Between " + first + " to " + mid + "\nEnter Number2 Between " + (mid + 1) + " to " + last);
                num = Convert.ToInt32(Console.ReadLine());
                mid = (first + last) / 2;
                if (num == 1)
                    first = mid;
                else
                    first = mid + 1;
            }
            return first;
        }
    }
}
