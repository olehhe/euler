using System;
using Euler.Problems;
using Euler.Problems.Models;
using Euler.Problems.Utils;

namespace Euler.Engine 
{
    public static class ProblemRunner
    {
        public static void Start()
        {
            Console.WriteLine("ENGINE STARTUP!");

            /* Problem: Multiples of 3 and 5 */
            new MultiplesOf3And5().Solve();

            /* Problem: Even fibonacci numbers */
            new EvenFibonacciNumbers().Solve();

            /* Problem: Largest prime factor */
            new LargestPrimeFactor().Solve();

            Console.WriteLine("ENGINE SHUTDOWN!");
        }
    }

}