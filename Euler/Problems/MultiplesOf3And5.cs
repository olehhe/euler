using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Euler.Problems.Interfaces;
using Euler.Problems.Models;
using Euler.Problems.Utils;

namespace Euler.Problems
{
    public class MultiplesOf3And5 : IProblem
    {
        public void Solve()
        {
            var sw = new Stopwatch();
            sw.Start();

            const int startNum = 0;
            const int endNum = 1000;
            const int m1 = 3;
            const int m2 = 5;

            var sum = Enumerable
                .Range(startNum, endNum)
                .Where(x => x % m1 == 0 || x % m2 == 0)
                .Sum();

            sw.Stop();

            ResultPrinter.PrintResult(
                nameof(MultiplesOf3And5), 
                new EulerResult
                {
                    Result = sum,
                    RunningTime = sw.Elapsed
                }
            );
        }
    }
}
