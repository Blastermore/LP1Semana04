using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec, int x)
        {
            string final = $" {s} ";
            for (int i = 1; i <= x; i++)
            {
                final = $"{dec}" + final + $"{dec}";
            }
            return final;
        }
        static void Main(string[] args)
        {
            char dec = char.Parse(args[1]);
            int x = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0], dec, x));

        }
    }
}
