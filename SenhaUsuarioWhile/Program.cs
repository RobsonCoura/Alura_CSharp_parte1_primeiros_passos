using System;

namespace SenhaUsuarioWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //while (condicao)
            int tentativas = 1;
            int qtdTentativasMaxima = 3;
            bool usuarioValido = false;
            string usuario = "a";
            string senha = "a";

            while (tentativas <= qtdTentativasMaxima)
            {
                Console.WriteLine("Digite um usuário:");
                string inputUsuario = Console.ReadLine();
                Console.WriteLine("Digite uma senha:");
                string inputSenha = Console.ReadLine();

                if (usuario == inputUsuario && senha == inputSenha)
                {
                    usuarioValido = true;
                    break;
                }
                else
                {
                    if (tentativas < qtdTentativasMaxima)
                    {
                        Console.WriteLine("Usuário ou senha inválido. Tente novamente.");
                    }
                }
                tentativas++;
            }
        }
    }
}