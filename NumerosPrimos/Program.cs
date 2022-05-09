using System;
using System.Collections.Generic;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Desafio dos Números Primos";
            List<int> u_input = new List<int>();
            int input;
            int pares = 0, impares = 0, soma = 0, maiorNum = 0, menorNum;
            bool primo = false;
            do
            {
                Console.WriteLine("Digite um número natural:");
                bool inputParse = int.TryParse(Console.ReadLine(), out input);
                if (input <= 3 && input > 0)
                {
                    primo = true;
                }
                else if (input < 0)
                {
                    Console.WriteLine("Número inválido!");
                    continue;
                }
                for (int possivelDivisor = 2; possivelDivisor <= input / 2; possivelDivisor++)
                {
                    if (input % possivelDivisor == 0)
                    {
                        break;
                    }
                    else if (possivelDivisor == input / 2)
                    {
                        primo = true;
                    }
                }
                u_input.Add(input);

            } while (!primo);
            foreach (int num in u_input)
            {
                if (num % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }

                soma = soma + num;

            }
            menorNum = u_input[0];
            foreach (int num in u_input)
            {
                if (menorNum > num)
                {
                    menorNum = num;
                }
                if (maiorNum < num)
                {
                    maiorNum = num;
                }
            }
            List<int> randomicos = new List<int>();

            Random random = new Random();

            for (int i = 0; i < u_input.Count / 3; i++)
            {
                int numRandom = random.Next(menorNum + 1, maiorNum);
                randomicos.Add(numRandom);
            }
            List<int> intersec = new List<int>();

            foreach (int r in randomicos)
            {
                if (u_input.Contains(r))
                {
                    intersec.Add(r);
                }
            }
            Console.WriteLine("Quantidade de números pares: {0}.", pares);
            Console.WriteLine("Quantidade de números ímpares: {0}.", impares);
            Console.WriteLine("Soma dos números: {0}.", soma);
            Console.WriteLine("O menor número é: {0}.", menorNum);
            Console.WriteLine("O maior número é: {0}.", maiorNum);
            Console.WriteLine("Os numeros randômicos são: {0}", String.Join(",", randomicos));

            if (u_input.Count >= 3 && intersec.Count != 0)
            {
                Console.WriteLine($"Os números {String.Join(",", intersec)} da lista randômica estão presentes no input do usuário.");
            }

            foreach (int r in intersec) // Retira os números randômicos
            {
                u_input.Remove(r);
            }
            Console.WriteLine("Retirando os números randômicos encontrados, a sua lista de input agora é: {0}.", String.Join(",", u_input));
        }

    }
}
