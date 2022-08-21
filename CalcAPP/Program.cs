using System;

namespace CalcAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            // A simple calculator
            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter your operator");
            string ops = Console.ReadLine();

            Console.WriteLine("Enter another number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (ops == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (ops == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (ops == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (ops == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (ops == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("invalid operator");
             }


        }
    }   
}
