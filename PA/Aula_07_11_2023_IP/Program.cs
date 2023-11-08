using System;

namespace Aula_07_11_2023_IP
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.Write("Informe um Nº: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("O Nº é par !");
            }
            else
            {
                Console.WriteLine("O Nº é ímpar !");
            }
        }
    }
}
