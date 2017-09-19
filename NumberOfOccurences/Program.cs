using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOccurences
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 4564674;
            int search = 4;

            string strNum = number.ToString();
            int occurences = 0;

            foreach (char c in strNum)
            {
                if (search == char.GetNumericValue(c))
                {
                   
                    occurences = occurences + 1;
                }

            }

            Console.WriteLine(occurences);
        }
    }
}
