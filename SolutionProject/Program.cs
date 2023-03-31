using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user_name;

            Console.Write("Enter your name: ");

            user_name = Console.ReadLine();

            Console.WriteLine("Hello {0}!",user_name);

        }
    }
}
