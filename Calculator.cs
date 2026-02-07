using System;

namespace LoopingCalculator
{
    class Calculator
    {
        public static bool IsValidOperation(char op)
        {
            return op == '+' || op == '-' || op == '*' ||
                   op == '/' || op == '%' || op == '=';
        }

        public static object Calculate(int a, int b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;

                case '-':
                    return a - b;

                case '*':
                    return a * b;

                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        return null;
                    }
                    return (double)a / b;

                case '%':
                    if (b == 0)
                    {
                        Console.WriteLine("Cannot modulo by zero");
                        return null;
                    }
                    return a % b;

                default:
                    return null;
            }
        }
    }
}
