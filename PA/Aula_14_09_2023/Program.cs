﻿using System;

namespace Aula_14_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, n3, n4, media;
            Console.Write("Informe a Nota 1º: ");
            n1 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a Nota 2º: ");
            n2 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a Nota 3º: ");
            n3 = decimal.Parse(Console.ReadLine());

            Console.Write("Informe a Nota 4º: ");
            n4 = decimal.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média final é: " + media);
            Console.WriteLine($"A média final é: {media}");
        }
    }
}
