using System;

namespace Task3._14_ondord_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 eded daxil olunacaq.");
            Console.Write("Birinci olaraq 6-Reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci olaraq 6-Reqemli ededi daxil edin: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uchuncu olaraq 6-Reqemli ededi daxil edin: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dorduncu olaraq 7-Reqemli ededi daxil edin: ");
            int a3 = Convert.ToInt32(Console.ReadLine());
            if (a > 99999 && a <= 999999 && a1 > 99999 && a1 <= 999999
                && a2 > 99999 && a2 <= 999999 && a3 > 999999 && a3 <= 9999999)
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
                Console.Write("Birinci ededin ilk 3 reqeminin cemi: ");
                Console.WriteLine(b+x+e);
                //birinci
                int b1 = a1 / 100000;
                // ikinci
                int y1 = a1 - (b1 * 100000);
                int x1= y1 / 10000;
                //ucuncu
                int c1 = a1 / 10000;
                int d1= a1- (c1 * 10000);
                int e1 = d1 / 1000;
                Console.Write("Ikinci ededin ilk 3 reqeminin cemi: ");
                Console.WriteLine(b1 + x1 + e1);
                //birinci
                int b2 = a2 / 100000;
                // ikinci
                int y2 = a2 - (b2 * 100000);
                int x2 = y2 / 10000;
                //ucuncu
                int c2 = a2 / 10000;
                int d2 = a2 - (c * 10000);
                int e2 = d2 / 1000;
                Console.Write("Uchuncu ededin ilk 3 reqeminin cemi: ");
                Console.WriteLine(b2 + x2 + e2);
                Console.Write("Butun 6 reqemlilerin ilk 3 reqemlerinin cemi: ");
                int q = b + b1 + b2 + x + x1 + x2 + e + e1 + e2;
                Console.WriteLine(q);
                Console.Write("7-reqemli ededin son 4 reqemi: ");
                int b3 = a3 / 10000;
                int c3 = (b3 * 10000);
                int d3 = a3 -c3;
                Console.WriteLine(d3);
                Console.Write("Son iki neticenin Cemi: ");
                Console.WriteLine(d3+q);
                Console.Write("Cemden 7-reqemlinin ilk 3 reqmeninin ferqi: ");
                Console.WriteLine(d3+q-b3);
                int t1 = d3 + q - b3;
                Console.Write("Neticenin 60%-nin sonuna 60 reqemi artirilmish formasi: ");
                int t2 = t1 * 60 / 100;
                int t3 = (t2 * 100) + 60;
                Console.WriteLine(t3);
                Console.Write("Neticeden 18%-ini cixdiqda: ");
                int t4 = t3 * 18 / 100;
                int t5 = t3 - t4;
                Console.WriteLine(t5);


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
