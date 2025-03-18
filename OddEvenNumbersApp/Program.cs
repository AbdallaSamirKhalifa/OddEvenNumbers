using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers", Numbers);
            PrintNumbers("Even No", Numbers.Where(x => IsEven(x)));
            PrintNumbers("Odd No", Numbers.Where(x => IsOdd(x)));

            Console.ReadKey();
        }
        static void PrintNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach(var n in numbers)
            {
            Console.Write($" {n}");


            }
            Console.Write($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        static bool IsOdd(int number)
        {
            if (number % 2 != 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
