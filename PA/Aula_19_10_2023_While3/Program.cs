using System;

namespace Aula_19_10_2023_While3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator, limite;
            Console.Write("Informe o Fator:");
            fator = int.Parse(Console.ReadLine());

            Console.Write("Informe o Nº Final:");
            limite = int.Parse(Console.ReadLine());

            int contador = 1;
            while (contador <= limite)
            {
                Console.WriteLine($"{fator} x {contador} = {fator * contador}");
                contador++;
            }
            Console.WriteLine("Fim da Tabuada");
        }
    }
}
