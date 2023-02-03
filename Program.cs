using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o primeiro numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("entre com a operação (+, -, *, /): ");
            string op = Console.ReadLine();

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            Console.WriteLine("Resultado: " + result);
        }
    }
}