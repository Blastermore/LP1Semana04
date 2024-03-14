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
            Console.WriteLine(Decor("Good Morning!", '*', 3));
            Console.WriteLine(Decor("Good Morning!", '.', 3));

        }
    }
}
