using System;

namespace BetterDecorator
{
    /// <summary>
    /// Includes two methods - Decor and Main; the first formats the string
    /// that we want to print while Main just converts agrs elements to 
    /// adequate types to be used by the Decor method
    /// </summary>
    class Program
    {
        /// <summary>
        /// Formats the string s by adding the dec char to each end of the 
        /// string x times
        /// </summary>
        /// <param name="s">String to be decorated</param> 
        /// <param name="dec">The decor char to be added to string ends</param>
        /// <param name="x">Number of times dec gets added in each
        /// string extremity</param>
        /// <returns>The formatted string</returns>
        private static string Decor(string s, char dec, int x)
        {
            string final = $" {s} ";
            for (int i = 1; i <= x; i++)
            {
                final = $"{dec}" + final + $"{dec}";
            }
            return final;
        }

        private static string Decor()
        {
            string str = Decor("User did not specify args!", '=', 3);
            return str;
        }


        /// <summary>
        /// Converts each args element to the adequate type to be used by the
        /// Decor method and prints the returning formatted string
        /// </summary>
        /// <param name="args">Array with 3 elements - the string to be
        /// formatted, the dcor to be added to each ending and the
        /// number of times the dec char gets added to each extremity</param>
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                char dec = char.Parse(args[1]);
                int x = int.Parse(args[2]);
                Console.WriteLine(Decor(args[0], dec, x));
            }
            else if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }

        }
    }
}
