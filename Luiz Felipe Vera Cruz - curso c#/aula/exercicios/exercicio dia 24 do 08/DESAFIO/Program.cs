using System;

namespace DESAFIO
{
    class Program
    {
        static void Main(string[] args)

        // Faça um programa que receba a idade de um nadador e imprima a sua
        // categoria seguindo as regras:
        // CategoriaIdade
        // Infantil A 5 – 7 anos
        // Infantil B 8 – 10 anos
        // Juvenil A 11 – 13 anos
        // Juvenil B 14 – 17 anos
        // Sênior Maiores de 18 anos
        {
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            // bool permissao = ;

            if(idade >=18){
                Console.WriteLine("CATEGORIA: Sênior");
                Console.WriteLine("------------------------------");

             }else if(idade >=14){
                Console.WriteLine("CATEGORIA: Juvenial A");
                Console.WriteLine("------------------------------");

            }else if(idade >=11){
                Console.WriteLine("CATEGORIA: Juvenial B");
                Console.WriteLine("------------------------------");
            }else if(idade >=8){
                Console.WriteLine("CATEGORIA: Infaltil A");
                Console.WriteLine("------------------------------");

            }else if(idade >=5){
                Console.WriteLine("CATEGORIA: Infaltil B");
                Console.WriteLine("------------------------------");

            }else if(idade <=4){
                Console.WriteLine("Poxa que pena, muito novo(a)!");
                Console.WriteLine("------------------------------");
            }
        
            
            
        }
    }
}
