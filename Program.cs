using System;
using Calculadora; 

namespace Calculadora
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

            double result = Calculadora.Calcular(op, num1, num2);


          
            

           
          
            Console.WriteLine("Resultado:" + result);
        }
    }
}