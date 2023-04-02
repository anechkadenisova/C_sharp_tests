using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator();
            // Test2();
            // Test3();
            // Test4();
        }

        public static void calculator()
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
                case '+':                         //Операция сложения
                    result = operand1 + operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '-':                        //Операция вычитание
                    result = operand1 - operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '*':                       //Операция умножение
                    result = operand1 * operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                case '/' when operand2 > 0:     //Операция деления с доп.проверкой на ноль
                    result = operand1 / operand2;
                    Console.WriteLine("Result = " + result);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}