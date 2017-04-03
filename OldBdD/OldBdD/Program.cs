using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBdD
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGuess.ConsoleUserOpportunities();
            /*
            // Method for auto-testing
            // Enter a number. If this method write in console the same number
            // than the programm works correctly.
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberGuess.StartGuess(n));
            */

            Console.ReadKey();
        }

        public const int MAX_VALUE = 10000;
    }
}
