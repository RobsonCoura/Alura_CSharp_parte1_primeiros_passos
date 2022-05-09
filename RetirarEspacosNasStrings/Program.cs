using System;

namespace RetirarEspacosNasStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplos para retirar espaços nas strings no inicio, meio, fim.

            string saudacoes = "      Hello Word!      ";
            Console.WriteLine($"[{saudacoes}]");

            string saudacaoModificada = saudacoes.TrimStart();
            Console.WriteLine($"[{saudacaoModificada}]");

            saudacaoModificada = saudacoes.TrimEnd();
            Console.WriteLine($"[{saudacaoModificada}]");

            saudacaoModificada = saudacoes.Trim();
            Console.WriteLine($"[{saudacaoModificada}]");
            Console.ReadLine();
        }
    }
}
