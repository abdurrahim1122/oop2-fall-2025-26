using System;

class DoWhileCalculator
{
    static void Main()
    {
        double num1, num2, result;
        char operation;
        char choice;

        do
        {
            Console.WriteLine("=== Simple Calculator ===");

            
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

           switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error! Division by zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }

            Console.Write("\nDo you want to perform another calculation? (y/n): ");
            choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

        } while (choice == 'y' || choice == 'Y');

        Console.WriteLine("Thank you for using the calculator!");
    }
}
