using System;

namespace Aula_17_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            string operador;

            Console.Write("Informe o 1ºN: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Informe o 2ºN: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Informe a operação desejada: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine("Resultado da soma dos Nº é: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Resultado da subtração dos Nº é: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Resultado da multiplicação dos Nº é: " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Resultado da divisão dos Nº é: " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Operação não registrada... Tente novamente!");
                    break;
            }
        }
    }
}
