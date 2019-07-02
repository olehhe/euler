using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler.Problems.Interfaces;
using Euler.Problems.Models;
using Euler.Problems.Utils;

namespace Euler.Problems
{
    public class LargestPrimeFactor : IProblem
    {
        public void Solve()
        {
            var sw = new Stopwatch();
            sw.Start();

            long num = 600851475143;
            var result = FindFactors(num).Max();

            sw.Stop();

            ResultPrinter.PrintResult(
                nameof(LargestPrimeFactor),
                new EulerResult
                {
                    Result = result,
                    RunningTime = sw.Elapsed
                }
            );
        }

        private List<long> FindFactors(long num)
        {
            var result = new List<long>();
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    factor += 2;
                }
            }

            if (num > 1) result.Add(num);

            return result;
        }
    }
}
