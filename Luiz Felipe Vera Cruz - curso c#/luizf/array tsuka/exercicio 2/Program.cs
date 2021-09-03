using System;

namespace array_tsuka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int [] numeros = new int[6];
            for(var i = 0; i < 6; i ++){
                Console.WriteLine($"Insiro o {i + 1} valor");
                numeros[i] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine("Valores cadastrados");
            
            
            Console.WriteLine("Exibindo com foreach");
            int qtdImpar = 0;
            int qtdPar = 0;
            foreach (var item in numeros){
                if(item % 2 == 0){

                    qtdPar++;
                }else
                {
                    qtdImpar++;
                }

            }// fim foreach
            Console.WriteLine($"Quantidade de pares = {qtdPar}");
            Console.WriteLine($"Quantidade de impares = {qtdImpar}");


        }
    }
}
