using System;

namespace Aula_26_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, percFreq;

            Console.Write("Informe sua 1° Nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Informe sua 2° Nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Informe sua 3° Nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Informe sua 4° Nota: ");
            n4 = float.Parse(Console.ReadLine());

            Console.Write("Informe o % de Frequência: ");
            percFreq = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media < 5 && percFreq <= 40)
            {
                Console.WriteLine("Aluno Reprovado");
            } else if (media < 7 && percFreq <= 60)
            {
                Console.WriteLine("Aluno de Recuperação");
            } else if (media <= 10 && percFreq > 60)
            {
                Console.WriteLine("Aluno Aprovado");
            } else
            {
                Console.WriteLine("Será analisado pela secretária acadêmica");
            }
        }
    }
}
