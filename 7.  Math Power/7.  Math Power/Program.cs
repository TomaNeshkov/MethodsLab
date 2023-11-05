using System;

class Program
{
    public static double CalculatePower(double number, double power)
    {
        return Math.Pow(number, power);
    }

    static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double result = CalculatePower(num1, num2);

        Console.WriteLine(result);
    }
}
