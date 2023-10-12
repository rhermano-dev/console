using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class Calculator
    {
        public int PerformOperation(string operation, int a, int b)
        {
            int result = 0;

            if (operation == "add")
            {
                result = a + b;
            }
            else if (operation == "subtract")
            {
                result = a - b;
            }
            else if (operation == "multiply")
            {
                result = a * b;
            }
            else if (operation == "divide")
            {
                if (b != 0)
                {
                    result = a / b;
                }
                else
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid operation.");
            }

            return result;
        }

        public string GetOperationDescription(string operation)
        {
            switch (operation)
            {
                case "add":
                    return "Addition";
                case "subtract":
                    return "Subtraction";
                case "multiply":
                    return "Multiplication";
                case "divide":
                    return "Division";
                default:
                    return "Unknown";
            }
        }

        public void LoopAndPrint(int n)
        {
            for (int i = 0; i < n; i++)
            {
                switch (i % 3)
                {
                    case 0:
                        Console.WriteLine($"Iteration {i}: Multiple of 3");
                        break;
                    case 1:
                        Console.WriteLine($"Iteration {i}: Remainder 1");
                        break;
                    case 2:
                        Console.WriteLine($"Iteration {i}: Remainder 2");
                        break;
                }
            }
        }
    }
}
