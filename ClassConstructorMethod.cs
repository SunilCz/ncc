//1.Write a program to show class, constructor, properties and method
using System;

namespace ClassExample
{
    class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Method
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I am {Age} years old.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of the Person class using the constructor
            Person person1 = new Person("FirstName", "LastName", 99);

            // Accessing the properties
            Console.WriteLine($"First Name: {person1.FirstName}");
            Console.WriteLine($"Last Name: {person1.LastName}");
            Console.WriteLine($"Age: {person1.Age}");

            // Calling the method
            person1.SayHello();

        }
    }
}