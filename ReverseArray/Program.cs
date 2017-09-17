using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {

            //string input;
            //char delimeter = ',';
            //WriteLine("Type your numbers seperated by comma");
            //input = ReadLine();
            //string[] numbers;
            //numbers = input.Split(delimeter);

            //foreach (string num in numbers)
            //{
            //    Write(num + " ");
            //}
            //WriteLine();

            int[] numbers = { 2, 4, 7, 9, 10, 14, 15 };
            int upper = numbers.GetUpperBound(0);
            int lower = numbers.GetLowerBound(0);

            for (int i = upper; i >= lower ;i-- )
            {
                Write(numbers[i] + " ");
            }

            ReadKey();
        }
    }
}
