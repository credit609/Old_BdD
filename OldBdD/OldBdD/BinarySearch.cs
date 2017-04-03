using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBdD
{
    class BinarySearch
    {
        private static int StartSearch(int[] array, int value)
        {
            // Checking for relevant input parametres
            if (array.Length < 1 || array == null || array.Min() > value || array.Max() < value)
                return -1;

            // Algorythm of searching @value in @array
            int low = 0;
            int high = array.Length - 1;
            int middle = (int)Math.Floor((low + high) / 2.0);
            while (low < high)
            {
                middle = (int)Math.Floor((low + high) / 2.0);
                if (array[middle] >= value)
                    high = middle;
                else
                {
                    low = middle + 1;
                }
            }
            return high;
        }
        public static void SimpleTest()
        {
            // Testing on the simpliest test
            int[] SimpleArray = new[] { 1, 2, 3, 4, 5 };
            if (StartSearch(SimpleArray, 4) != 3)
                Console.WriteLine("! Поиск не нашёл число 4 среди чисел {1, 2, 3, 4, 5}");
            else
                Console.WriteLine("Поиск на простом тесте работает корректно");
        }
        public static void TestNegativeNumbers()
        {
            // Testing search in negative numbers
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (StartSearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3,- 2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }
        public static void TestNonExistentElement()
        {
            // Testing search for missing element
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (StartSearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат");
        }
        public static void TestRepeatingNumbers()
        {
            // Testing search for repeating numbers in array
            int[] repeatNumbers = new[] { -2, -1, 8, 8, 8, 15 };
            if (StartSearch(repeatNumbers, 8) < 2 || StartSearch(repeatNumbers, 8) > 4)
                Console.WriteLine("! Поиск не нашёл число 8 среди чисел {-2, 8, 3, 8, -1, 5}");
            else
                Console.WriteLine("Поиск среди повторяющихся чисел работает корректно");
        }

        public static void TestEmptyArray()
        {
            // Testing search in empty array
            int[] emptyArray = new int[] { };
            if (StartSearch(emptyArray, 42) != -1)
                Console.WriteLine("! Поиск в пустом массиве работает некорректно");
            else
                Console.WriteLine("Поиск в пустом массиве работает корректно");
        }
        public static void StressTest()
        {
            // Testing search in huge array
            const int numberOfNumbers = 10001;
            bool temp = false;
            int[] bigAmountOfNumbers = new int[numberOfNumbers];
            for (int i = 0; i < numberOfNumbers; i++)
            {
                bigAmountOfNumbers[i] = i;
            }
            for (int i = 0; i < numberOfNumbers; i++)
            {
                if (StartSearch(bigAmountOfNumbers, i) != i)
                    temp = true;
            }
            if (temp)
                Console.WriteLine("! Стресс-тест не пройден");
            else
                Console.WriteLine("Стресс-тест пройден");
        }
    }
}