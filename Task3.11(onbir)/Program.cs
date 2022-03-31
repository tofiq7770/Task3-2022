using System;

namespace Task3._11_onbir_
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.Write("8-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 9999999 && a <= 99999999)
            {
                //birinci
                int b = a / 100000000;

                //ucuncu
                int c = a / 10000000;
                int d = a - (c * 10000000);
                int e = d / 1000000;
                //besinci
                int f = a % 100000;
                int t = f / 10000;
                //Yeddinci
                int v = a % 1000;
                int n = f / 100;
                int p = n % 10;
                //doqquzuncu
                int q = a % 10;
                Console.Write("Cut yerde olan ededlerden yaranan eded: ");
             
                Console.Write(e);
                Console.Write(t);
                Console.Write(p);
                Console.WriteLine(q);
                int a1 = b * 10000;
                int a2 = e * 1000;
                int a3 = t * 100;
                int a4 = p * 10;
                int a5 = q;
                int a6 = a1 + a2 + a3 + a4 + a5;
                //ikinci
                int y = a - (b * 100000000);
                int x = y / 10000000;

                //dorduncu
                int f1 = a % 1000000;
                int t1 = f1 / 100000;
                //altinci
                int f2 = a % 10000;
                int t2 = f2 / 1000;

                //sekkizinci
                int f3 = a % 100;
                int t3 = f3 / 10;
                Console.Write("Tek yerde olan ededlerden yaranan eded: ");
                Console.Write(x);
                Console.Write(t1);
                Console.Write(t2);
                Console.WriteLine(t3);
                Console.Write("Cemi: ");
                int a11 = x * 1000;
                int a21 = t1 * 100;
                int a31 = t2 * 10;
                int a41 = t3; 
                int a7 = a11 + a21 + a31 + a41;
                int cem = a6 + a7;
                Console.WriteLine(cem);
                Console.Write("Sonuna 88 elave etdikde: ");
                int cem1 = (cem * 100)+88;
                Console.WriteLine(cem1);
                int cem2 = cem1 * 18 / 100;
                Console.Write("Ededden 18%-ini cixdiqda: ");
                int cem3 = cem1 - cem2;
                Console.WriteLine(cem3);

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
