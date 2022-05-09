using System;

namespace SubstituirStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplos para substituir strings com o Replace 

            string digaOla = "Olá mundo";
            Console.WriteLine(digaOla);

            digaOla = digaOla.Replace("Olá", "Saudações");
            Console.WriteLine(digaOla);
            Console.ReadLine();
        }
    }
}
