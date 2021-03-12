using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            string textoModificado;

            Console.Write("Escreva algo para falar como o Cebolinha: ");
            texto= Console.ReadLine();

            textoModificado= texto.Replace("r","l").Replace("rr","l").Replace("rR","l").Replace("R","L").Replace("RR","L").Replace("Rr","L");

            Console.WriteLine($"Sua fala: {textoModificado}");

        }
    }
}
