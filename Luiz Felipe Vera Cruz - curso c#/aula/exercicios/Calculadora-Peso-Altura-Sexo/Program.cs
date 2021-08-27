using System;

namespace Calculadora_Peso_Altura_Sexo
{
    class Program
    {
        private const string V = "";

        static void Main(string[] args)
        {
            //Faça um programa que receba a idade, o peso, altura, e o sexo de 10 pessoas. Calcule e exiba
            //a - total de homens
            //b - Total de mulheres
            //c - Média de idade dos homens
            //d - média de idade das mulheres
            //e - Quantidade de pessoas que estão acima do peso, abaixo do peso e com peso ideal

            //IMC - PESO / ALTURA * ALTURA

            int peso = 0;
            int altura = 0;
            string sexo = "";
            int idade = 0;

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            peso = int.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu sexo (F - Feminino) ou (M - Masculino): ");
            sexo = (Console.ReadLine());







        }
    }
}
