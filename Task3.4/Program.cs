using System;

namespace Task3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("5-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9999 && a <= 99999)
            {
                //ilk reqem
                int b = a / 10000;
                //son reqem
                int c = a % 10;
                Console.Write("Ilk reqem: ");
                    Console.WriteLine(b);
                Console.Write("Son reqem: ");
                    Console.WriteLine(c);
                Console.Write("Reqemlein ceminin kvadrati: ");
                int d = (b + c) * (b + c);
                Console.WriteLine(d);










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
