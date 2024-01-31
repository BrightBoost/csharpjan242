using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniExercises.switchAndEnums
{
    public class SimpleCalculator
    {

        enum Operation { Add, Subtract, Multiply, Divide, Modulus, Exponentiation }

        public static void Calc()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation: Add, Subtract, Multiply, Divide, Modulus, Exponentiation");
            Operation operation = (Operation)Enum.Parse(typeof(Operation), Console.ReadLine(), true);

            double result;

            switch (operation)
            {
                case Operation.Add:
                    result = num1 + num2;
                    break;
                case Operation.Subtract:
                    result = num1 - num2;
                    break;
                case Operation.Multiply:
                    result = num1 * num2;
                    break;
                case Operation.Divide:
                    result = num1 / num2;
                    break;
                case Operation.Modulus:
                    result = num1 % num2;
                    break;
                case Operation.Exponentiation:
                    result = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }

}
}
