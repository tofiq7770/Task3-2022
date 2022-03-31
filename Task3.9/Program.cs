using System;

namespace Task3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("9-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 99999999 && a <= 999999999)
            {
                //birinci
                int b = a / 100000000;
              
                //ucuncu
                int c = a / 10000000;
                int d = a - (c * 10000000);
                int e = d / 1000000;
                //besinci
                int f = a % 100000;
                int t = f/10000 ;
                //Yeddinci
                int v = a % 1000;
                int n = f / 100;
                int p = n % 10;
                //doqquzuncu
                int q = a % 10;
                Console.Write("Tek yerde olan ededlerden yaranan eded: ");
                Console.Write(b);
                Console.Write(e);
                Console.Write(t);
                Console.Write(p);
                Console.Write(q);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shert yanlishdir");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            
        }
    }
}
