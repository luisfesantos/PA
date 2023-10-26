using System;

namespace Aula_26_10_2023_DoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorFinanciado;
            int qtdParcela, contador = 1;

            Console.Write("Informe o valor financiado: ");
            valorFinanciado = float.Parse(Console.ReadLine());

            Console.Write("Informe a Qtd de parcelas: ");
            qtdParcela = int.Parse(Console.ReadLine());

            DateTime data = DateTime.Now.Date;

            while (contador <= qtdParcela)
            {
                Console.WriteLine($"{contador}ª parcela ({data}): {valorFinanciado / qtdParcela:0.00}");
                contador++;
                data = data.AddMonths(1);
            }

        }
    }
}
