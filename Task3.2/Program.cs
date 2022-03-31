using System;

namespace Task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("6-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 99999 && a <= 999999)
            {
                //birinci
                int b = a / 100000;
                // ikinci
                int y = a - (b * 100000);
                int x = y / 10000;
                //ucuncu
                int c = a / 10000;
                int d = a - (c * 10000);
                int e = d / 1000;
                
                Console.Write("Birinci  reqem: ");
                Console.WriteLine(b);
                Console.Write("Ikinci  reqem: ");
                Console.WriteLine(x);
                Console.Write("Ucuncu  reqem: ");
                Console.WriteLine(e);
                Console.Write("Reqemlerin cemi: ");
                int g = b + x + e;
                Console.WriteLine(g);
            


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert yanlishdir");
                Console.ForegroundColor = ConsoleColor.White;


            }


        }
    }
}

