using System;

namespace Aula_21_11_2023_ExForIF2
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto, cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, nulo = 0, branco = 0;

            for (;;)
            {
                Console.Write("Informe seu voto: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 0)
                {
                    break;
                }
                if (voto == 1)
                {
                    cand1++;
                } 
                if (voto == 2)
                {
                    cand2++;
                }
                if (voto == 3)
                {
                    cand3++;
                }
                if (voto == 4)
                {
                    cand4++;
                }
                if (voto == 5)
                {
                    nulo++;
                }
                if (voto == 6)
                {
                    branco++;
                }

            }

                Console.WriteLine($"Candidato 1º: {cand1} Votos");
                Console.WriteLine($"Candidato 2º: {cand2} Votos");
                Console.WriteLine($"Candidato 3º: {cand3} Votos");
                Console.WriteLine($"Candidato 4º: {cand4} Votos");
                Console.WriteLine($"Votos Nulos: {nulo} Votos");
                Console.WriteLine($"Votos em Branco: {branco} Votos");
        }
    }
}
