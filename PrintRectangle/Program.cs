using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 30;
            int width = 20;

            string lenSide = "";
            string widSide = "";

            for (int i = 1; i <= length; i++)
            {
                lenSide = lenSide + "*";
                if (i == 1)
                {
                    widSide = "*";
                }
                else if (i == length)
                {
                    widSide = widSide + "*";
                }
                else
                {
                    widSide = widSide + " ";
                }
                

            }
            Console.WriteLine(lenSide);
            for (int i = 1; i <= width - 2; i++)
            {
                Console.WriteLine(widSide);
            }
            Console.WriteLine(lenSide);
        }
    }
}
