using System;

namespace Task3._6
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
                int b = a / 10000000;
                int c = b * 10000000;
                int d = a - c;
                int f = a % 10;
                int g = (d - f)/10;
                Console.Write("Birinci ve sonuncu reqemleri ededden sildikde: ");
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
