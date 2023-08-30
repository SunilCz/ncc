//5. Write a program to demonstrate multiple inheritance using interface
using System;

namespace MultipleInheritace
{
    // Animal interface
    public interface IAnimal
    {
        void Eat();
    }

    public interface ICat
    {
        void Meow();
    }

    // Cat class implementing IAnimal interface
    public class Cat : IAnimal, ICat
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating.");
        }

        public void Meow()
        {
            Console.WriteLine("Cat is meowing.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat(); // Output: Cat is eating.
            cat.Meow(); // Output: Cat is meowing.
        }
    }
}