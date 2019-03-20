using System;

namespace SandBox
{
    /// <summary>
    /// Question 16.5
    /// </summary>
    public class TrailingZeros
    {
        public int TrailingZerosOptimized(int n)
        {
            var numTwos = 0;
            var numFives = 0;
            var numTens = 0;

            var factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                var (CurTwos, CurFives, CurTens) = NumDivisibleBy2510(i);
                numTwos = numTwos + CurTwos;
                numFives = numFives + CurFives;
                numTens = numTens + CurTens;
            }

            return numTens + Math.Min(numFives, numTwos);
        }

        public (int NumTwos, int NumFives, int NumTens) NumDivisibleBy2510(int n)
        {
            var numTwos = 0;
            var numFives = 0;
            var numTens = 0;

            while ((n % 10 == 0 || n % 2 == 0 || n % 5 == 0) && n > 0)
            {
                if (n % 10 == 0)
                {
                    n = n / 10;
                    numTens++;
                }
                else if (n % 5 == 0)
                {
                    n = n / 5;
                    numFives++;
                }
                else if (n % 2 == 0)
                {
                    n = n / 2;
                    numTwos++;
                }
            }

            return (numTwos, numFives, numTens);
        }


        public int TrailingZerosBruteForce(int n)
        {
            var trailingZeros = 0;
            var fact = Factorial(n);
            var stringify = fact.ToString();

            for (int i = stringify.Length - 1; i >= 0; i--)
            {
                if (stringify[i] == '0')
                {
                    trailingZeros++;
                }
                else
                {
                    break;
                }
            }

            return trailingZeros;
        }

        private long Factorial(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
