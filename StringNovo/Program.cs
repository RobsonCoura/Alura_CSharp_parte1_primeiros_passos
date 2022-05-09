using System;

namespace VerificacaoString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string letraDaMusica = "Você diz adeus, e eu digo olá";

            var resultadado = letraDaMusica.Contains("digo");
            Console.WriteLine(resultadado);
            //Console.WriteLine(letraDaMusica.Contains("adeus"));
            Console.WriteLine(letraDaMusica.Contains("amém"));
            Console.ReadLine();
        }
    }
}
