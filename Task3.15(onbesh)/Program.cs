using System;

namespace Task3._15_onbesh_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 eded daxil olunacaq.");
            Console.Write("Birinci olaraq 3-Reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci olaraq 3-Reqemli ededi daxil edin: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uchuncu olaraq 6-Reqemli ededi daxil edin: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dorduncu olaraq 6-Reqemli ededi daxil edin: ");
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dorduncu olaraq 7-Reqemli ededi daxil edin: ");
            int a4 = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a <= 999 && a1 > 99 && a1 <= 999
                && a2 > 99999 && a2 <= 999999 && a3 > 99999
                && a3 <= 999999 && a4 > 999999 && a4 <= 9999999)
            {
                Console.Write("Birinci 3-reqemlinin ededleri cemi: ");
                //birinci
                int b = a / 100;
                // ikinci
                int y = a - (b * 100);
                int o = y / 10;
                //ucuncu
                int r = a % 10;
                int t = b + o + r;
                Console.WriteLine(t);
                Console.Write("Ikinci 3-reqemlinin ededleri cemi: ");
                //birinci
                int b1 = a1 / 100;
                // ikinci
                int y1 = a1 - (b1* 100);
                int o1 = y1 / 10;
                //ucuncu
                int r1 = a1 % 10;
                int t1 = b1 + o1 + r1;
                Console.WriteLine(t1);
                Console.Write("3-reqemlilerin ededleri cemi: ");
                int h = t + t1;
                Console.WriteLine(h);
                Console.Write("Cemin sondan iki reqeminin kvadrati: ");
                Console.WriteLine(h*h);
                Console.Write("Bu netice ile 3-reqemli ededlerin birleshmesinin cemi: ");
                int v = (a * 1000) + a1+(h*h);
                Console.WriteLine(v);
                int b4 = a4 % 100000;
                Console.Write("Neticeden 7-reqemlinin son 5 reqemini cixdiqda: ");
                Console.WriteLine(v-b4);
                Console.Write("Uzerine 6-reqemlilerin ceminin son 3 reqemini geldikde: ");
                int b2 = a2 + a3;
                int b3 = b2 % 1000;
                Console.WriteLine(b3);
                //birinci
                int b5 = a4 / 1000000;
                // ikinci
                int y4 = a4 - (b5 * 1000000);
                int x4 = y4 / 100000;
                //ucuncu
                int c4 = a4 / 10000;
                int d4 = c4 % 10;
                //dorduncu
                int e4 = a4 / 1000;
                int f4 = e4 % 10;
                //beshinci
                int e14 = a4 / 100;
                int f14 = e14 % 10;
                //altinci
                int e24 = a4 / 10;
                int f24 = e24 % 10;
                //yeddinci
                int f34 = a4 % 10;
                Console.Write("7-reqemlinin cemini tersi: ");
                int yeddicem = b5 + x4 + d4 + f4 + f14 + f24 + f34;
                int y24 = yeddicem/10;
                int y25=yeddicem%10;
                int y26= (y25 * 10) +y24;
                Console.WriteLine(y26);
                Console.Write("@@-Neticenin sonuna 11 elave etdikde: ");
                int y27 = (y26 * 100) + 11;
                Console.WriteLine(y27);
                Console.Write("@@-7-reqemlinin tek yerde olan ededlerden emele geli: ");
                int y29 = b5 + d4 + f14 + f34;
                Console.WriteLine(y29);
                Console.Write("@@--ishare olunmush neticelerin ferqi: ");
                int y30 = y27 - y29;
                Console.WriteLine(y30);
                int y31 = y30 % 10;
                int y32 = y30 - y31;
                int y33 = (y32 * 100) + 880 + y31;
                Console.Write("Sondan ikinciye 88 ededini elave etdikde: ");
                Console.WriteLine(y33);

                





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
