using System;

namespace aulaDeDado
{
    class Program
    {
        static void Main(string[] args)
        {
            RolarDado();
        }

        static void RolarDado()
        {
            Random rd = new Random();
            Console.WriteLine("Número aleatório é: " + rd.Next(1, 100));

        }

    }
}
