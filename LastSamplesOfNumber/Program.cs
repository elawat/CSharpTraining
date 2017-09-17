using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSamplesOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 18;
            int sample = 4;
            string output = "";

            for (int i = num - 1; i >= num - sample; i--)
            {
                output = output +" " + i;
            }
            Console.WriteLine(output);

        }
    }
}
