using System;
using System.Collections;
using System.Collections.Generic;

namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lev1 = { "zero", "one", "two", "three", "four", "five","six","seven","eight","nine" };
            string[] lev2 = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] lev3 = { "twenty", "thirdy", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };



            List<String[]> list = new List<String[]>();

            list.Add(lev1);
            list.Add(lev2);
            list.Add(lev3);

            List<string> output = new List<string>();

            int num = 42;
            string numst = num.ToString();

            int len = numst.Length;

            
          
            double index = char.GetNumericValue(numst[numst.Length - 1]);

            int lastTwo = 0;
            if (len > 1)
            {
                lastTwo = Convert.ToInt32(numst.Substring(numst.Length - 2, 2));
            }

            List<int> integers = new List<int>();

            foreach (char c in numst)
            {
                integers.Add((int)char.GetNumericValue(c));
            }

            foreach (int i in integers)
            {

            }

           // Console.WriteLine(index);

            /// teen case
            int exclude = 0;
            if (len == 1)
            {
                output.Add(list[0][(int)index]);
            }
            else if (num < 20 && len == 2)
            {
                output.Add(list[1][(int)index]);
            }
            else
            {
                if (lastTwo < 20 && lastTwo != 0)
                {
                    output.Add(list[1][(int)index]);
                    exclude = 2;
                }

                Console.WriteLine(list[2][2]);

                for (int i = 1; i <= integers.Count - exclude; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(integers.Count);

                    output.Add(list[integers.Count][integers[i]]);
                }

            }



            foreach (string s in output)
            {


                Console.WriteLine(s);

            }

           
        }
    }
}
