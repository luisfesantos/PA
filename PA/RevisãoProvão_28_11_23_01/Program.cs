using System;

namespace RevisãoProvão_28_11_23_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numero;
            Console.Write("Informe um Nº: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                for(int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine($"5 x {cont} = {5 * cont}");
                }
            } 
            else
            {
                if (numero >= 11 && numero <= 10)
                { 
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        Console.WriteLine($"8 x {contador} = {8 * contador}");
                    }
                }
                else
                {
                    for (int contador = 10; contador >= 1; contador--)
                    {
                        Console.WriteLine($"7 x {contador} = {7 * contador}");
                    }
                }
            }
            */
            /*
            int numero, nImpar = 0, nPar = 0;
            for (int cont = 1; cont <= 15; cont++)
            {

                Console.Write("Informe um Nº: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 1)
                {
                    nImpar++;
                }
                else
                {
                    nPar++;
                }
            }

            Console.WriteLine($"Nºs pares: {nPar} ");
            Console.WriteLine($"Nºs impares: {nImpar} ");
            */
            /*
            int numero;
            Console.Write("Informe um Nº: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 10)
            {
                for (int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine($"5 x {cont} = {5 * cont}");
                }
            }
            else if (numero >= 11 && numero <= 10)
            {
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine($"8 x {contador} = {8 * contador}");
                }
            }
            else
            {
                for (int contador = 10; contador >= 1; contador--)
                {
                    Console.WriteLine($"7 x {contador} = {7 * contador}");
                }
            }
            */
            int num1, num2;
            string operador;

            Console.Write("Digite o 1ºN: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2ºN: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o operador: ");
            operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Operador invalido!");
                    break;
            }






        }
    }
}
