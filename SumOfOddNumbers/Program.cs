using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            int sum = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out limit))
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (i%2 != 0)
                    {
                        sum = sum + i;
                    }
                }
            }

            Console.WriteLine(sum);
    

        }
    }
}
