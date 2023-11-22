using System;

namespace Aula_21_11_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura, alturaMA = 0, alturaMN = 0;
            for (int pessoas = 1; pessoas <= 15; pessoas++)
            {
                Console.Write("Informe altura:");
                altura = float.Parse(Console.ReadLine());

                if (altura > alturaMA)
                {
                    alturaMA = altura;
                }
                if (altura < alturaMN || alturaMN == 0)
                {
                    alturaMN = altura;
                }
            }

            Console.WriteLine($"A Maior altura é: {alturaMA} e a Menor é: {alturaMN}");
        }
    }
}
