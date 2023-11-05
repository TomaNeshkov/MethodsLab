using System;

class Program
{
    static void Main(string[] args)
    {
        double num1 = int.Parse(Console.ReadLine());
        string opperation = Console.ReadLine();
        double num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Calculate(num1, opperation, num2));
    }
    static double Calculate(double a, string command, double b)
    {
        double result = 0;
        switch (command)
        {
            case "*":
                result += a * b;
                break;
            case "+":
                result += a + b;
                break;
            case "-":
                result += a - b;
                break;
            case "/":
                result += a / b;
                break;

        }
        return result;
    }
}

