using System;

namespace Task3._12_oniki_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci 5-Reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci 5-Reqemli ededi daxil edin: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if (a > 9999 && a <= 99999 && a1 > 9999 && a1 <= 99999)
            {
                //birinci reqem
                int b = a / 10000;
                // ikinci
                int y = a - (b * 10000);
                int x = y / 1000;
                //ucuncu
                int c = a / 1000;
                int d = a - (c * 1000);
                int e = d / 100;
                //dorduncu
                int f1 = a % 100;
                int t1 = f1 /10;
                //beshinci
                int t2 = a % 10;
                Console.Write("Ededin reqemlerinin cemi: ");
                int cem = b + x + e + t1 + t2;
                Console.WriteLine(cem);
                int b1 = a1 / 10000;
                // ikinci
                int y1 = a1 - (b1 * 10000);
                int x1 = y1 / 1000;
                //ucuncu
                int c1 = a1 / 1000;
                int d1 = a1 - (c * 1000);
                int e1 = d1 / 100;
                //dorduncu
                int f11 = a1 % 100;
                int t11 = f11 / 10;
                //beshinci
                int t21 = a1 % 10;
                int hasil = b1 * x1 * e1 * t11 * t21;
                Console.Write("Ededin reqemlerinin hasili: ");
                Console.WriteLine(hasil);
                Console.Write("Neticelerin cemi: ");
                Console.WriteLine(hasil+cem);
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
