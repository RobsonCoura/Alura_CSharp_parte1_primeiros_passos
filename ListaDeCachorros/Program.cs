using System;
using System.Collections.Generic;

namespace ListaDeCachorros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação da Lista de cachorros adicionando todas as raças
            var cachorros = new List<string> { "Boby", "Thor", "Pink", "Shakira"};
            Console.WriteLine("1° Execução");
            foreach (var cao in cachorros)
            {
                Console.WriteLine(cao);
            }
            cachorros.Remove("Boby");
            Console.WriteLine("2° Execução");
            foreach(var cao in cachorros)
            {
                Console.WriteLine(cao);
            }


            //var cachorros = new List<string>();
            //cachorros.Add("Boby");
            //cachorros.Add("Thor");
            //cachorros.Add("Pink");
            //cachorros.Add("Shakira");
            ////Iterar pela lista
            //foreach(var cao in cachorros)
            //{
            //    Console.WriteLine(cao);
            //}
        }
    }
}
