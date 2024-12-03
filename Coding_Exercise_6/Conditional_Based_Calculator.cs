using System;

namespace Coding_Exercise_6
{
    internal class Conditional_Based_Calculator
    {
        public Conditional_Based_Calculator()
        {
            SimpleCalculator();
        }

        public static void SimpleCalculator()
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operation: +, -, *, /");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine("Result: " + (num1 + num2));
                        break;

                    case "-":
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;

                    case "*":
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;

                    case "/":
                        if (num2 != 0)
                        {
                            Console.WriteLine("Result: " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                        break;
                }

                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string response = Console.ReadLine();
                if (response.ToLower() != "yes")
                {
                    continueCalculating = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                }
            }
        }

        static void Main(string[] args)
        {
            Conditional_Based_Calculator calculator = new Conditional_Based_Calculator();
        }
    }
}
