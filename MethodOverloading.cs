//2.Write a program to demonstrate method overloading
using System;

namespace MethodOverloadingExample
{
    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two double numbers
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to add three double numbers
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int sum1 = calculator.Add(5, 10);
            int sum2 = calculator.Add(5, 10, 15);
            double sum3 = calculator.Add(2.5, 3.5);
            double sum4 = calculator.Add(2.5, 3.5, 4.5);

            Console.WriteLine("Sum1: " + sum1); // Output: Sum1: 15
            Console.WriteLine("Sum2: " + sum2); // Output: Sum2: 30
            Console.WriteLine("Sum3: " + sum3); // Output: Sum3: 6
            Console.WriteLine("Sum4: " + sum4); // Output: Sum4: 10.5
        }
    }
}