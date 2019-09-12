using System;
using System.Collections.Generic;
using System.Numerics;

namespace Powers
{
    class Program
    {

        static void Main()
        {
            var minPower = 2;
            var maxPower = 100;

            var minBase = 2;
            var maxBase = 100;

            var sortedSet = new SortedSet<BigInteger>();

            for (var a = minBase; a <= maxBase; a++)
            {
                for (var b = minPower; b <= maxPower; b++)
                {
                    sortedSet.Add(BigInteger.Pow(a, b));
                }
            }
            Console.WriteLine(sortedSet.Count);
        }
    }
}
