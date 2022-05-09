using System;

namespace NumerosInteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();
            */

            //Primeiro faz a multiplicação e depois faz a soma  
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
            Console.ReadLine();


            /*
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) * c;
            Console.WriteLine(d);
            Console.ReadLine();
            */


            //Conta para descobrir o restante da divisão de dois numeros inteiros
            /*
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"Quociente: {d}");
            Console.WriteLine($"Restante: {e}");
            Console.ReadLine(); 
            */

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"O intervalo de números inteiros é {min} para {max}");

            int what = max + 3;
            Console.WriteLine($"Um exemplo de transbordamento: {what}");
            Console.ReadLine();
        }
    }
}
