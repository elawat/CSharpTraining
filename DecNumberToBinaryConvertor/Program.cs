using System;
using System.Collections;


namespace DecNumberToBinaryConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string input;
            int value;
            int div = 2;
            string binary = "";
            int n;
            ArrayList al = new ArrayList();

            input = Console.ReadLine();
            if (Int32.TryParse(input, out value))
            {
                n = value;
               while (n >= 1)
                {
                    
                    if (n % div == 0)
                    {
                        al.Add (0);
                    }
                    else
                    {
                        al.Add(1);
                    }
                    n = n / div;
                }
                al.Reverse();
                foreach(int i in al)
                {
                    binary = binary + i;
                }

                Console.WriteLine(binary);

            }





        }
    }
}
