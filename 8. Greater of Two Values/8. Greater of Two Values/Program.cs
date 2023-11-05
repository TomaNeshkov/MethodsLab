using System;

internal class Program
{
    static void Main(string[] args)
    {
        string valueType = Console.ReadLine();
        GetMax(valueType);
    }

    static void GetMax(string valueType)
    {
        switch (valueType)
        {
            case "int":
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
                break;

            case "char":
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());

                if (char1 < char2)
                {
                    Console.WriteLine(char2);
                }
                else
                {
                    Console.WriteLine(char1);
                }
                break;

            case "string":
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                int result = string.Compare(str1, str2);

                if (result > 0)
                {
                    Console.WriteLine(str1);
                }
                else if (result < 0)
                {
                    Console.WriteLine(str2);
                }
                break;
        }
    }
}
