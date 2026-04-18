// Name: Ray Jones
// Course: CST-250
// Instructor: Gary Ratterree
// Assignment: Activity 3 – Recursion
// Date: 4/19/26

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace FactorialRecursion.Services.BusinessLogicLayer
{
    internal class FactorialLogic
    {
        /// <summary>
        /// Solves factorial using iteration.
        /// </summary>
        internal BigInteger SolveIterativeFactorial(int factorial)
        {
            BigInteger result = 1;

            for (int i = factorial; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Solves factorial using recursion.
        /// </summary>
        internal BigInteger SolveRecursiveFactorial(int factorial)
        {
            // Base case
            if (factorial == 0 || factorial == 1)
            {
                return 1;
            }

            // Recursive call
            return factorial * SolveRecursiveFactorial(factorial - 1);
        }
    }
}