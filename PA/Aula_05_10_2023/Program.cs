using System;

namespace Aula_05_10_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            float num1, num2;
            string operador;

            Console.Write("Informe o 1ºN: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Informe o 2ºN: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Informe a operação desejada: ");
            operador = Console.ReadLine();
         
            if (operador == "+")
            {
                Console.WriteLine("Resultado da soma dos Nº é: "+ (num1 + num2));
            } else if (operador == "-")
            {
                Console.WriteLine("Resultado da subtração dos Nº é: "+ (num1 - num2));
            } else if (operador == "*")
            {
                Console.WriteLine("Resultado da multiplicação dos Nº é: "+ (num1 * num2));
            } else if (operador == "/")
            {
                Console.WriteLine("Resultado da divisão dos Nº é: "+ (num1 / num2));
            } else
            {
                Console.WriteLine("Operação não registrada... Tente novamente!");
            }


            /* 2
            int numero;
            Console.Write("Informe um número:");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 10)
            {
                Console.WriteLine("O Nº informado é igual maior que 10");
            } else
            {
                Console.WriteLine("O Nº informado é menor que 10");
            }


            / 3
            float salario, reajuste;
            Console.Write("Informe seu salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 3000)
            {
                reajuste = (salario * 50) / 100;
                Console.WriteLine("Reajuste aplicado: " + (salario + reajuste));
            } else if (salario <= 7000)
            {
                reajuste = (salario * 20) / 100;
                Console.WriteLine("Reajuste aplicado: " + (salario + reajuste));
            } else if (salario <= 10000)
            {
                reajuste = (salario * 15) / 100;
                Console.WriteLine("Reajuste aplicado: " + (salario + reajuste));
            } else
            {
                reajuste = (salario * 10) / 100;
                Console.WriteLine("Reajuste aplicado: " + (salario + reajuste));
            }*/
        }
    }
}
