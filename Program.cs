using System;

namespace aulaDeDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Rolar Dado");
            Console.WriteLine("2 - Sair");

            Console.WriteLine("");
            Console.WriteLine("Selecione uma opção: ");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: RolarDado(); break;
                case 2: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida, Pressione Enter para continuar"); Console.ReadLine(); Menu(); break;
            }

        }

        static void RolarDado()
        {
            Console.Clear();
            Escrever("Digite o número de lados do seu dado: ");
            int quantidadeDeLadosDoDado = LerVariavelEConverterParaInteiro();

            Random rd = new Random();
            int numeroRolado = rd.Next(1, quantidadeDeLadosDoDado + 1);

            Escrever($"Número do dado rolado é: {numeroRolado}");
            Console.ReadKey();
            Menu();
        }

        static void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }

        private static int LerVariavelEConverterParaInteiro()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
