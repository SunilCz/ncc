//6. Write a program to demonstrate abstract class
using System;

namespace Abstract
{
    // Abstract class Shape
    public abstract class Shape
    {
        // Abstract method
        public abstract double CalculateArea();

        // Concrete method
        public void Display()
        {
            Console.WriteLine($"Square - Area: {CalculateArea()}");
        }
    }

    // Square class inheriting from Shape
    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        // Implementation of abstract method
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Square square = new Square(7);
            square.Display(); // Output: Square - Side: 7, Area: 49
        }
    }
}
