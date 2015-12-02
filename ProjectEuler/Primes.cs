using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public static class Primes
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int m = (int)Math.Sqrt(n);

            for (int i = 3; i <= m; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public static List<int> GetPrimes()
        {
            List<int> result = new List<int>();
            result.Add(2);

            for (int i = 3; i < 10000000; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        public static long SumPrimes(int n)
        {
            long sum = 0;
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}