using System;

namespace aulaDeDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever("Digite o número de lados do seu dado: ");
            int quantidadeDeLadosDoDado = Convert.ToInt32(Console.ReadLine());

            int numeroRolado = RolarDado(quantidadeDeLadosDoDado);
            Escrever($"Número do dado rolado é: {numeroRolado}");
        }

        static int RolarDado(int quantidadeDeLadosDoDado)
        {
            Random rd = new Random();
            int numeroRolado = rd.Next(1, quantidadeDeLadosDoDado + 1);
            return numeroRolado;
        }

        static void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
