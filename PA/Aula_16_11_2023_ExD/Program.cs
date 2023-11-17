using System;

namespace Aula_16_11_2023_ExD
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, idadeMedia = 0, pessoas = 0;

            /* While
            while (true)
            {
                Console.Write("Informe a idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                {
                    break;
                }

                pessoas++;
                idadeMedia += idade;
            }
            Console.WriteLine($"A idade média foi: {idadeMedia / pessoas}");
            */

            /* For
            for (;;)
            {
                Console.Write("Informe a idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                {
                    break;
                }

                pessoas++;
                idadeMedia += idade;
            }
            Console.WriteLine($"A idade média foi: {idadeMedia / pessoas}");
            */

            /* DoWhile
            do
            {
                Console.Write("Informe a idade:");
                idade = int.Parse(Console.ReadLine());

                if (idade == 0)
                {
                    break;
                }

                pessoas++;
                idadeMedia += idade;
            } while (idade > 0);
            Console.WriteLine($"A idade média foi: {idadeMedia / pessoas}");
            */
        }
    }
}
