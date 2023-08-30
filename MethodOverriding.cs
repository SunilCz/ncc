//4.Write a program to demonstrate method overriding condition
using System;

namespace MethodOverriding
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal is making a sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.MakeSound(); // Output: Animal is making a sound.

            Dog dog = new Dog();
            dog.MakeSound(); // Output: Dog is barking.
        }
    }
}