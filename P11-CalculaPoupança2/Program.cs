using System;

namespace P11_CalculaPoupança2For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valorInvestido += valorInvestido * 0.0036;
                //valorInvestido = valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após" + contadorMes + "meses, você terá R$" + valorInvestido);
            }
        }
    }
}
