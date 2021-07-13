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
            Escrever("O que deseja fazer?");
            Escrever("-------------------------------");
            Escrever("1 - Rolar Dado");
            Escrever("2 - Sair");

            Escrever("");
            Escrever("Selecione uma opção: ");
            short resposta = short.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1: RolarDado(); break;
                case 2: System.Environment.Exit(0); break;
                default: Escrever("Opção inválida, Pressione Enter para continuar"); Console.ReadLine(); Menu(); break;
            }

        }

        static void RolarDado()
        {
            Console.Clear();
            Escrever("Digite o número de lados do seu dado: ");
            int quantidadeDeLadosDoDado = LerVariavelEConverterParaInteiro();

            quantidadeDeLadosDoDado = ValidaNumeroDeLadosDoDado(quantidadeDeLadosDoDado);


            Random rd = new Random();
            int numeroRolado = rd.Next(1, quantidadeDeLadosDoDado + 1);

            Escrever("");
            Escrever($"Número do dado rolado é: {numeroRolado}");
            VerificaNumeroParOuImpar(numeroRolado);
            Console.ReadKey();
            Menu();
        }

        static int ValidaNumeroDeLadosDoDado(int ladosDoDado)
        {
            if (ladosDoDado >= 1 && ladosDoDado <= 100)
            {
                return ladosDoDado;
            }
            else
            {
                Escrever("Valor inválido, o dado deve possuir entre 1 e 100 lados. Escolha um valor correto: ");
                ladosDoDado = int.Parse(Console.ReadLine());
                return ValidaNumeroDeLadosDoDado(ladosDoDado);
            }
        }

        static void VerificaNumeroParOuImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Escrever("O número é par!");
            }
            else
            {
                Escrever("O número é ímpar!");
            }
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
