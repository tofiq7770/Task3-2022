using System;

namespace Task3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("6-Reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 99999 && a <= 999999)
            {
                //birinci reqem
                int b = a / 100000;
                Console.Write("Birinci reqem: ");
                Console.WriteLine(b);
                int c = (a * 10) + b;
                Console.Write("Birinci reqemi ededin sonuna artirdiqda: ");
                Console.WriteLine(c);





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
