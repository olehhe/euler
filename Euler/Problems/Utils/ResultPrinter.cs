using System;
using System.Collections.Generic;
using System.Text;
using Euler.Problems.Models;

namespace Euler.Problems.Utils
{
    public static class ResultPrinter
    {
        public static void PrintResult(string problemName, EulerResult result)
        {
            Console.WriteLine($"Problem = '{problemName}'\nResult: {result.Result}. Time: {result.RunningTime}");
        }
    }
}
