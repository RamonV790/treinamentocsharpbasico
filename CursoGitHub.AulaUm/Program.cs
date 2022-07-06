using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaUm
{
    internal class Program
    {
        static void Main(string[] args)
        
             
        {
            int idade;
            int dia;
            Console.WriteLine("Aula 1 - GitHub");
            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());
            if (idade <= 15)
            {
                Console.WriteLine("GitHub Sesi");

            }
            else
            {
                Console.WriteLine("GitHub Senai");
                Console.WriteLine("Qual o melhor dia para uma aula presencial?");
                Console.WriteLine("1-Seg 2-Ter 3-Qua 4-Qui 5-Sex 6-Sab");
                dia = int.Parse(Console.ReadLine());
                switch(dia)
                {
                    case 1: Console.WriteLine("Segunda-Feira".ToUpper()); break;
                    case 2: Console.WriteLine("Terça-Feira".ToUpper()); break;
                    case 3: Console.WriteLine("Quarta-Feira".ToUpper()); break;
                    case 4: Console.WriteLine("Quinta-Feira".ToUpper()); break;
                    case 5: Console.WriteLine("Sexta-Feira".ToUpper()); break;
                    case 6: Console.WriteLine("Sábado".ToUpper()); break;
                    default: Console.WriteLine("Dado inserido fora do padrão".ToUpper());break;
                    
                }
                Console.WriteLine("Qual o seu nome completo?");
                string nome = Console.ReadLine();
                Console.WriteLine($"Tudo mínusculo:{nome.ToLower()}");
                Console.WriteLine($"Tamanho do string: {nome.Length}");
                Console.WriteLine($"Tem R no seu nome:{nome.Contains("R")}");
                Console.WriteLine($"Sem os 5 primeiros caracteres: {nome.Substring(5)}");
            }

           

            Console.ReadKey();
            }
        }
    }

