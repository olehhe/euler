using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Euler.Problems.Interfaces;
using Euler.Problems.Models;
using Euler.Problems.Utils;

namespace Euler.Problems
{
    public class EvenFibonacciNumbers : IProblem
    {
        public void Solve()
        {
            var sw = new Stopwatch();
            sw.Start();
            const int threshold = 4000000; // four million
            var fibs = GetFibs(threshold);

            var sum = fibs.Where(x => x % 2 == 0).Sum();

            sw.Stop();

            ResultPrinter.PrintResult(
                nameof(EvenFibonacciNumbers),
                new EulerResult
                {
                    Result = sum,
                    RunningTime = sw.Elapsed
                }
            );
        }

        private List<int> GetFibs(int threshold)
        {

            var fib1 = 0;
            var fib2 = 1;
            var fibs = new List<int> {fib1, fib2};

            while (true)
            {
                var fibNext = fib1 + fib2;

                if (fibNext > threshold) break;

                fibs.Add(fibNext);
                fib1 = fib2;
                fib2 = fibNext;
            }

            return fibs;
        }
    }
}
