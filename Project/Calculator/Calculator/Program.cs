using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueCalculation;

            do
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                string operation = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            continue; // Skip to the next iteration of the loop
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        continue; // Skip to the next iteration of the loop
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation? (yes/no): ");
                continueCalculation = Console.ReadLine().ToLower();

            } while (continueCalculation == "yes");

            Console.WriteLine("Calculator application closed.");
        }
    }
}
