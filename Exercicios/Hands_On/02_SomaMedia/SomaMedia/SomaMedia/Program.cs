using System;
using System.Collections.Generic;

namespace SomaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos valores deseja informar:");
            int quantidadeDeValores = int.Parse(Console.ReadLine());

            var listaDeValores = ColetarValores(quantidadeDeValores);
            Console.WriteLine($"A soma dos valores é: {CalcularSoma(listaDeValores)}");
            Console.WriteLine($"A média dos valores é: {CalcularMedia(listaDeValores)}");
        }

        static List<decimal> ColetarValores(int quantidadeValores)
        {
            List<decimal> listaDeValores = new List<decimal>(quantidadeValores);

            for (int i = 0; i < quantidadeValores; i++)
            {
                Console.WriteLine($"Informe o valor {i + 1}");
                listaDeValores.Add(decimal.Parse(Console.ReadLine()));
            }

            return listaDeValores;
        }

        static decimal CalcularSoma(List<decimal> listaDeValores)
        {
            decimal total = 0;
            foreach (decimal valor in listaDeValores)
                total += valor;

            return total;
        }

        static decimal CalcularMedia(List<decimal> listaDeValores)
        {
            decimal soma = CalcularSoma(listaDeValores);
            decimal media = soma / listaDeValores.Count;
            return media;
        }
    }
}
