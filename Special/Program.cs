using System;

namespace Special
{
    class Program
    {
        private static int GetSpecial(int n)
        {
            int r;
            if (n == 0 || n == 1)
            {
                r = n;
            }
            else
            {
                r = GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
            }
            return r;
        } 
        static void Main(string[] args)
        {   
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
        }
    }
}
