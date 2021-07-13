using System;

namespace aulaDeDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever("Digite o número de lados do seu dado: ");
            int quantidadeDeLadosDoDado = LerVariavelEConverterParaInteiro();

            int numeroRolado = RolarDado(quantidadeDeLadosDoDado);
            Escrever($"Número do dado rolado é: {numeroRolado}");
        }

        private static int LerVariavelEConverterParaInteiro()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static int RolarDado(int quantidadeDeLadosDoDado)
        {
            Random rd = new Random();
            return rd.Next(1, quantidadeDeLadosDoDado + 1);
        }

        static void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
