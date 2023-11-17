using System;

namespace Aula_16_11_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.Write("Informe um Nº");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 0; contador <= numero; contador++)
            {
                if (contador % 2 == 1)
                {
                    Console.WriteLine($"Nºs impares: {contador}");
                } 
                if (contador % 2 == 0)
                {
                    Console.WriteLine($"Nºs pares: {contador}");
                }
            }

        }
    }
}
