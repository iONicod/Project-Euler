using System;
using System.Numerics;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            BigInteger first = 1;
            BigInteger second = 1;
            var length = 1000;
            var maxValue = BigInteger.Pow(10, length - 1);

            BigInteger sum = 0;

            BigInteger result = 2;
            while (sum < maxValue)
            {
                result++;
                sum = first + second;
                first = second;
                second = sum;
            }
            Console.WriteLine(sum);
        }
    }
}
