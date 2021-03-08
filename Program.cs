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

            textoModificado= texto.Replace ("r","l");

            Console.WriteLine($"Sua fala: {textoModificado}");

        }
    }
}
