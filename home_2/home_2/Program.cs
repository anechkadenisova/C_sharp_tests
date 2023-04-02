using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calculator();
            find_range();
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
        public static void find_range()
        {
            
            Console.Write("Please, enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 14) //проверка числа на принадлежность к первому диапазону
            {
                Console.WriteLine("The number is in the range from 0 to 14");
            }
            else if (number >= 15 && number <= 35) //проверка числа на принадлежность ко второму диапазону
            {
                Console.WriteLine("The number is in the range from 15 to 35");
            }
            else if (number >= 36 && number <= 50)  //проверка числа на принадлежность к третьему диапазону
            {
                Console.WriteLine("The number is in the range from 36 to 50");
            }
            else if (number >= 51 && number <= 100) //проверка числа на принадлежность к четвертому диапазону
            {
                Console.WriteLine("The number is in the range from 51 to 100");
            }
            else //Сообщение что число не попадает ни под один диапазон
            {
                Console.WriteLine("The number does not fall within any range");
            }    
        }
    }
}