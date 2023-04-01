using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1();
            // Test2();
            // Test3();
            // Test4();
        }

        public static void Test1()
        {
            char operation;
            double result;
            Console.Write("Enter the first number: ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the arithmetic operation (+,-,*,/): ");
            operation = (char)Console.Read();

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '-':
                    result = operand1 - operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '*':
                    result = operand1 * operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '/':
                    result = operand1 / operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                default:
                    Console.WriteLine("hh");
                    break;
            }
        }
    }
}