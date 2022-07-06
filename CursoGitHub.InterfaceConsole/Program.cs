using System;

namespace CursoGitHub.InterfaceConsole
{ //Inicio do namespace
    internal class Program
    {//inicio da classe
        static void Main(string[] args)
        {//inicio do método
            /*
             * 
             * Main- principal
             * O método inicia-se com a letra maíuscula
             * 
             */
            //Variável
            /*
             * É um espaço reservado na memória
             */
            /* Tipos de dados
             * Inteiro - int
             * Real - double
             * Texto - string*/
            /*
             * * + -adição
             * - - subtração
             * * - multiplicação
             * / - divisão
             * % - mod (módulo da divisão
             */
            string comando;
            int pontos = 0;
         

            string resposta = "git remote add origin";
            Console.WriteLine("Qual o comando para adicionar o repositório remoto");
            comando = Console.ReadLine();
            string[] subcomando = comando.Split(' ');
            foreach (var item in subcomando)
            {
                Console.WriteLine(item);
            }
            if (comando.Equals(resposta))
            {
                Console.WriteLine("acertou, você ganhou 100 pontos");

            }
            else
            {
                if (comando.Contains("git remote"))
                {
                    Console.WriteLine("Bom, você acertou metade, você ganhou 50 pts");
                }
                if (comando.Contains("add origin"))
                {
                    Console.WriteLine("Bom, você acertou metade, você ganhou 50 pts");
                }

                else
                {
                    Console.WriteLine("errou");
                }
            }
                Console.WriteLine($"A resposta é {resposta}");
                Console.WriteLine("Alô Mundo!");
                Console.ReadKey();
            //fim do método
        }//fim da classe
    } //Fim do namespace
}