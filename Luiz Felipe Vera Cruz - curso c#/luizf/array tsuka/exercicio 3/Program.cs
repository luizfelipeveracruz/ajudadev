using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Faça um programa que receba a temperatura média de cada mês do ano e armazene essas temperaturas em um vetor.
            //a. Calcule e exiba a maior e a menor temperatura do ano.
            
             Console.Write("Digite a temperatura do mês atual: ");
            int [] temperatura = new int[12];
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
