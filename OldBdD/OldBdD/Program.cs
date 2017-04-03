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
            BinarySearch.SimpleTest();
            BinarySearch.TestNegativeNumbers();
            BinarySearch.TestRepeatingNumbers();
            BinarySearch.TestNonExistentElement();
            BinarySearch.TestEmptyArray();
            BinarySearch.StressTest();

            Console.ReadKey();
        }
    }
}
