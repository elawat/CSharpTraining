using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "my name is ABC";
            string[] arrWords = statement.Split(null);
            string newStatement = "";
            for (int i = arrWords.GetUpperBound(0); i >= arrWords.GetLowerBound(0); i--)
            {
                newStatement = newStatement + " " + arrWords[i];
            }

            Console.WriteLine(newStatement.Trim());
        }
    }
}
