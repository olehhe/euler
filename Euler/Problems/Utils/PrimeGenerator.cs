using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler.Problems.Utils
{
    public static class PrimeGenerator
    {
        public static List<long> Generate(long top)
        {
            var primes = new List<long>();
            for (var i = 0; i < top; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }

            return primes;
        }

        public static readonly Func<long, bool> IsPrime = x =>
        {
            if (x <= 3) return x > 1;
            else if (x % 2 == 0 || x % 3 == 0) return false;

            var i = 5;
            while (i * i <= x)
            {
                if (x % i == 0 || x % (i + 2) == 0)
                    return false;

                i += 6;
            }

            return true;
        };
    }
}
