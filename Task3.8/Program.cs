using System;

namespace Task3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("8-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9999999 && a <= 99999999)
            {
               
                //Sondan ucuncu
                int b = a / 1000;
                int d = a - (b * 1000);
                int e = d / 100;
                //Sonuncu
                int f = a % 10;
                Console.Write("Sondan ucuncu: ");
                Console.WriteLine(e);
                Console.Write("Sonuncu: ");
                Console.WriteLine(f);
                Console.Write("Cemi: ");
                int u = e + f;
                Console.WriteLine(u);

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
