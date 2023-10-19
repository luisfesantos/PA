using System;

namespace Aula_19_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator;
            Console.Write("Informe o Fator:");
            fator = int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                contador++;
            }
            Console.WriteLine("Fim da Tabuada");
        }
    }
}
