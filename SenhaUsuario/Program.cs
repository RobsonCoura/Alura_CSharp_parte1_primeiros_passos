using System;

namespace SenhaUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "a";
            string senha = "a";
            int qtdTentativasMaxima = 3;
            bool usuarioValido = false;

            //for(valor inicial do elemento; condicional de encerrar o laço, incremento)
            //mesmo resultado, com formas diferentes: :)
            ////i++
            ////i = i + 1;
            ////i += 1;
            for (int tentativas = 1; tentativas <= qtdTentativasMaxima; tentativas++)
            {
                Console.WriteLine("Digite um usuário:");
                string inputUsuario = Console.ReadLine();
                Console.WriteLine("Digite uma senha:");
                string inputSenha = Console.ReadLine();

               if (usuario == inputUsuario && senha == inputSenha)
               {
                   usuarioValido = true;
                    Console.WriteLine("Usuário logado com sucesso");
                    break;
               }
               else
               {
                   if (tentativas < qtdTentativasMaxima)
                    {
                       Console.WriteLine("Usuário ou senha inválido. Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine("Seu limite de tentativas expirou");
                    }
                }
            }
        }
    }
}
