using System;

namespace Task3._13_onuc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci 5-Reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci 5-Reqemli ededi daxil edin: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uchuncu 5-Reqemli ededi daxil edin: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            if (a > 9999 && a <= 99999 && a1 > 9999 && a1 <= 99999 && a2 > 9999 && a2 <= 99999)
            {
                //ilk reqem
                int b = a / 10000;
                //son reqem
                int c = a % 10;
                Console.Write("Ilk reqem: ");
                Console.WriteLine(b);
                Console.Write("Son reqem: ");
                Console.WriteLine(c);
                Console.Write("Onlardan alinan eded: ");
                int d = (b * 10) + c;
                Console.WriteLine(d);
                //ilk reqem
                int b1 = a1 / 10000;
                //son reqem
                int c1 = a1 % 10;
                Console.Write("Ilk reqem: ");
                Console.WriteLine(b1);
                Console.Write("Son reqem: ");
                Console.WriteLine(c1);
                Console.Write("Onlardan alinan eded: ");
                int d1 = (b1 * 10) + c1;
                //ilk reqem
                int b2 = a2 / 10000;
                //son reqem
                int c2 = a2 % 10;
                Console.Write("Ilk reqem: ");
                Console.WriteLine(b2);
                Console.Write("Son reqem: ");
                Console.WriteLine(c2);
                Console.Write("Onlardan alinan eded: ");
                double d2=(b2 * 10) + c2;
                Console.Write("Hamisinin cemi: ");
                Console.WriteLine(d+d1+d2);
                Console.Write("Neticenin 50%-i: ");
                Console.WriteLine((d + d1 + d2)/2);


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
