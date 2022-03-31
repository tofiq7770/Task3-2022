using System;

namespace Task3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("4-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 999 && a <= 9999)
            {
                //birinci
                int b = a / 1000;
                // ikinci
                int y = a - (b * 1000);
                int x = y / 100;
                //ucuncu
                int c = a / 100;
                int d = a - (c * 100);
                int e = d / 10;
                //dorduncu
                int r = a % 10;
                //Ededin tersinin emele gelmesi
                int g = r * 1000;
                int t = e * 100;
                int u = x * 10;

                int w = g + t + u + b;
                Console.Write("Ededin tersi: ");
                Console.WriteLine(w);

                int i = (w * 10) + 8;
                int j = i + 800000;
                Console.Write("Ededin tersinin sonuna ve evveline 8 artirdiqda: ");
                Console.WriteLine(j);


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
