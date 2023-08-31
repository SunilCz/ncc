using System;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public string Add(string a, string b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOperations math = new MathOperations();

        int result1 = math.Add(5, 10);
        Console.WriteLine($"Result 1: {result1}");

        double result2 = math.Add(3.14, 2.71);
        Console.WriteLine($"Result 2: {result2}");

        string result3 = math.Add("Hello, ", "world!");
        Console.WriteLine($"Result 3: {result3}");
    }
}
