using System;

namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>999 && a <=9999)
            {
                //birinci
                int b = a / 1000;
                // ikinci
                int y = a-(b*1000);
                int x = y / 100;
              //ucuncu
                int c = a / 100;
                int d = a-(c * 100);
                int e = d / 10;
                //dorduncu
                int r = a % 10;
                Console.Write("Birinci  reqem: ");
                Console.WriteLine(b);
                Console.Write("Ikinci  reqem: ");
                Console.WriteLine(x);
                Console.Write("Ucuncu  reqem: ");
                Console.WriteLine(e);
                Console.Write("Dorduncu  reqem: ");
                Console.WriteLine(r);
                Console.Write("Reqemlerin cemi: ");
                int g = b + x + e+r;
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
