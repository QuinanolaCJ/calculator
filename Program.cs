using System;

namespace LoopingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine())
                
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                char operation;

                while (true)
                {
                    Console.Write("Choose operation (+, -, *, /, %, =): ");
                    operation = Convert.ToChar(Console.ReadLine());

                    if (Calculator.IsValidOperation(operation))
                        break;

                    Console.WriteLine("Incorrect Operation Used, please try again");
                }

                
                if (operation == '=')
                {
                    isRunning = false;
                    break;
                }

                object result = Calculator.Calculate(num1, num2, operation);

                if (result != null)
                {
                    Console.WriteLine("Result: " + result);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Exiting Program...");
        }
    }
}
