using System;
using System.Collections.Generic;
using System.Linq;

//https://euler.jakumo.org/problems/view/44.html
// Задача 44. Пятиугольные числа

namespace Pentagonal
{
    class Program
    {
        private static List<int> _pentagonalNumbers = new List<int>();

        static void Main()
        {
            while (true)
            {
                _pentagonalNumbers.Add(GetPentagonalNumber(_pentagonalNumbers.Count + 1));
                var maxNumber = _pentagonalNumbers.Last();
                var pairNumber = FindPairNumber(maxNumber);
                if (!pairNumber.HasValue) continue;
                Console.WriteLine(maxNumber - pairNumber.Value);
                break;
            }
        }

        static int? FindPairNumber(int value)
        {
            var numbers = _pentagonalNumbers.Take(_pentagonalNumbers.Count - 1);
            foreach (var number in numbers)
            {
                if (IsPentagonal(value - number) && IsPentagonal(value + number))
                    return number;
            }
            return null;
        }

        static bool IsPentagonal(int number)
        {
            var n = 1;
            while (GetPentagonalNumber(n) < number)
                n++;
            return GetPentagonalNumber(n) == number;
        }
        
        static int GetPentagonalNumber( int n ) => n * (3 * n - 1) / 2;
    }
}
