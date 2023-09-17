using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Simple Calculator");
        
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /)");
            char alg = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (alg)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}