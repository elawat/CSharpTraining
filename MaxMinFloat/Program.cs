using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaxMinFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            // solution without LINQ
            float[] tempReadings = {(float)10.0, (float)11.3, 8, (float)-3.2 };

            float max = 0;
            float min = 0;

            for (int i = tempReadings.GetLowerBound(0); i <= tempReadings.GetUpperBound(0); i++)
            {
                if (tempReadings[i] > max)
                {
                    max = tempReadings[i];
                }
                if (tempReadings[i] < max)
                {
                    min = tempReadings[i];
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);

            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //var minL =
            //   from num in numbers
            //   where (num % 2) == 0
            //   select num;



        }
    }
}
