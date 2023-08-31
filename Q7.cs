//7. Write a program to demonstrate exception handline (try, catch, throw throws)

using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("num", "Number must be non-negative.");
            }

            int result = 10 / num;
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
