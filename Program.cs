// Name: Ray Jones
// Course: CST-250
// Instructor: Gary Ratterree
// Assignment: Activity 3 – Recursion
// Date: 4/19/26


using System;
using System.Numerics;
using FactorialRecursion.Services.BusinessLogicLayer;

namespace FactorialRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactorialLogic factorialLogic = new FactorialLogic();

            int userInput = Utility.ReadIntFromConsole("Enter a number for factorial: ");

            BigInteger iterativeResult = factorialLogic.SolveIterativeFactorial(userInput);
            BigInteger recursiveResult = factorialLogic.SolveRecursiveFactorial(userInput);

            Console.WriteLine($"\nIterative factorial of {userInput} = {iterativeResult}");
            Console.WriteLine($"Recursive factorial of {userInput} = {recursiveResult}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }

    internal static class Utility
    {
        /// <summary>
        /// Reads an integer from the console. 
        /// </summary>
        internal static int ReadIntFromConsole(string prompt)
        {
            int value;
            bool isValid = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";

                isValid = int.TryParse(input, out value);

                if (!isValid || value < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                    isValid = false;
                }

            } while (!isValid);

            return value;
        }
    }
}