//8. Write a program to demonstrate interface
using System;

namespace Interface
{
    // Interface for swimming behavior
    public interface ISwimmable
    {
        void Swim();
    }

    // Fish class implementing ISwimmable interface
    public class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("Fish is swimming.");
        }
    }

    // Duck class implementing both IFlyable and ISwimmable interfaces
    public class Duck :  ISwimmable
    {

        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Fish fish = new Fish();
            Duck duck = new Duck();
            fish.Swim(); // Output: Fish is swimming.
            duck.Swim(); // Output: Duck is swimming.
        }
    }

}