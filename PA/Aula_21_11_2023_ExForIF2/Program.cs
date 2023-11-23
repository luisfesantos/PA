using System;

namespace Aula_21_11_2023_ExForIF2
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto = -1, cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, nulo = 0, branco = 0, totalVotos = 0;

            while (voto != 0)
            {

                Console.Clear();
                Console.WriteLine("--=[ Candidatos ]=--");
                Console.WriteLine("-= 1 > Candidato 1º =-");
                Console.WriteLine("-= 2 > Candidato 2º =-");
                Console.WriteLine("-= 3 > Candidato 3º =-");
                Console.WriteLine("-= 4 > Candidato 4º =-");
                Console.WriteLine("-= 5 > Nulo =-");
                Console.WriteLine("-= 6 > Branco =-");
                Console.WriteLine("-- =  ~  = --");
                Console.Write("Informe seu voto: ");
                voto = int.Parse(Console.ReadLine());


                switch (voto)
                {
                    case 1:
                        cand1++;
                        break;

                    case 2:
                        cand2++;
                        break;
                    case 3:
                        cand3++;
                        break;
                    case 4:
                        cand4++;
                        break;
                    case 5:
                        nulo++;
                        break;
                    case 6:
                        branco++;
                        break;

                    default:
                        if (voto != 0)
                        {
                            Console.WriteLine("Voto não computado");
                            Console.ReadLine();
                        }
                        break;
                }
            }

            totalVotos = cand1 + cand2 + cand3 + cand4 + nulo + branco;
;

                Console.WriteLine("--= [   Apuração   ] =--");
                Console.WriteLine($"Candidato 1º: {cand1} Votos");
                Console.WriteLine($"Candidato 2º: {cand2} Votos");
                Console.WriteLine($"Candidato 3º: {cand3} Votos");
                Console.WriteLine($"Candidato 4º: {cand4} Votos");
                Console.WriteLine($"Nulo: {nulo} Votos");
                Console.WriteLine($"Branco: {branco} Votos");
                Console.WriteLine($"Percentual de Votos Nulo: {(100 / totalVotos) * nulo} %");
                Console.WriteLine($"Percentual de Votos Branco: {(100 / totalVotos) * branco} %");


















            /*
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
            */

        }
    }
}
