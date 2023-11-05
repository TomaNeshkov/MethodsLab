using System;

class Program
{
    static void Main(string[] args)
    {
        string operation = Console.ReadLine();
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());

        switch (operation)
        {
            case "add":
                Add(number1, number2);
                break;
            case "multiply":
                Multiply(number1, number2);
                break;
            case "subtract":
                Subtract(number1, number2);
                break;
            case "divide":
                Divide(number1, number2);
                break;
        }
    }

    static void Add(double num1, double num2)
    {
        Console.WriteLine(num1 + num2);
    }

    static void Multiply(double num1, double num2)
    {
        Console.WriteLine(num1 * num2);
    }

    static void Subtract(double num1, double num2)
    {
        Console.WriteLine(num1 - num2);
    }

    static void Divide(double num1, double num2)
    {
        if (num2 != 0)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
