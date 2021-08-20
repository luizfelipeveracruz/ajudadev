using System;

namespace exercicio_logica
{
    class Program
    {
        static void Main(string[] args)
        {



            //entrada de dados 

            Console.WriteLine("Calculadora de idade");
            Console.WriteLine("Digite o ano atual:");
            double anoAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu ano de nascimento:");
            double anoNascimento = double.Parse(Console.ReadLine());



            //processamento de dados 


            double idade = (anoAtual - anoNascimento);

            double semanas = (idade * 12) * 4;


            Console.WriteLine("Idade: " + idade);

            Console.WriteLine("Idade em semanas: " + semanas);

            // VERIFICAÇÃO DE IDADE
            if (idade >= 18)
            {

                Console.WriteLine("Bem-vindo");
                Console.WriteLine("Possui Ingresso? (sim ou não)");
                string resposta = Console.ReadLine();
                if (resposta == "sim")
                {
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine("Adiquira o ingresso!");
                }

            }
            else
            {
                Console.WriteLine("Entrada não permitida, entrar em contato com a bilheteria junto ao responsável.");

            }

            //VERIFICAÇÃO INGRESSO



            //saída de dados









        }
    }
}
