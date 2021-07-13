using System;

namespace aulaDeDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de lados do seu dado: ");
            int quantidadeDeLadosDoDado = Convert.ToInt32(Console.ReadLine());
            RolarDado(quantidadeDeLadosDoDado);
        }

        static void RolarDado(int quantidadeDeLadosDoDado)
        {
            Random rd = new Random();
            Console.WriteLine($"Número do dado rolado é: {rd.Next(1, quantidadeDeLadosDoDado + 1)}");

        }

    }
}
