//7. Write a program to demonstrate exception handline (try, catch, throw throws)
using System;

namespace ExceptionHandling
{
    class Calculator
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                // Throwing DivideByZeroException with a custom error message
                throw new DivideByZeroException("Divisor cannot be zero.");
            }

            return dividend / divisor;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                int result = calculator.Divide(10, 0);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}